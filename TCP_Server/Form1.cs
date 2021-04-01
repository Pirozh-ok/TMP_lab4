using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        private TcpListener serverSocket;
        const string IP = "127.0.0.1";
        const int port = 8080;
        string answer; // что передаёт сервер клиенту (сама информация)
        public Form1()
        {
            InitializeComponent();
            tIP.Text = IP;
        }

        private void bStartServer_Click(object sender, System.EventArgs e)
        {
            // создание сервера                
            serverSocket = new TcpListener(IPAddress.Any, port); // создаём сокет
            serverSocket.Start(); // запускаем сервер
            Thread myThread = new Thread(new ThreadStart(CycleServer));
            myThread.Start(); // запускаем поток
        }
        private void CycleServer()
        {
            //while (true)
            //{
                TcpClient clientSocket = serverSocket.AcceptTcpClient();
                NetworkStream stream = clientSocket.GetStream();

                /* сервер получает и обрабатывает запрос клиента */
                byte[] getBytes = new byte[1024];
                int realBytesSize = stream.Read(getBytes, 0, getBytes.Length);
                string request = Encoding.UTF8.GetString(getBytes, 0, realBytesSize);
                tGetServer.Text = request; 
                /*---------------------------------*/

                //ищем нужные папки/ файлы по указанному пути
                answer = "";
                FileAttributes attr = File.GetAttributes(request);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory) //если это каталог
                {
                    if (Directory.Exists(request))
                    {
                        string[] dirs = Directory.GetDirectories(request);     // считываем именна всех каталогов
                        string[] files = Directory.GetFiles(request);       // считываем именна всех файлов

                        for (int i = 0; i < dirs.Length; i++)
                        {
                            answer += dirs[i];
                            answer += "\n";
                        }

                        for (int i = 0; i < files.Length; i++)
                        {
                            answer += files[i];
                            answer += "\n";
                        }
                    }
                    else // эли это файл, то записываем его содержимое в строку
                    {
                        answer = File.ReadAllText(request);
                    }
                }
                /* сервер отвечает на запрос клиента */
                tSendServer.Text = answer;
                byte[] bytesMessage = Encoding.UTF8.GetBytes(answer); // преобразование сообщения сервера в байты
                stream.Write(bytesMessage, 0, bytesMessage.Length); //записываем в поток наши байты
                stream.Flush();   //  передаём их
                clientSocket.Close();  // закрываем сокет 
                /*----------------------------------------*/
           // }
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            serverSocket.Stop();
        }
    }
}

