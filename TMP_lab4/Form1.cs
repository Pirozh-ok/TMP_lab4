using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMP_lab4
{
    public partial class Form1 : Form
    {
        static private TcpClient client;
        static  private NetworkStream stream; 
        private const int port = 8080;
        private string IP;
        private string request; 
        public Form1()
        {
            InitializeComponent();
            // проверка ip адресса на корректность
            IP = tIP.Text;
           // bSendServer.Enabled = false; 
        }

        private void bConnect1_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    client = new TcpClient(IP, port); // по айпи и порту подключаемся к сети
            //    stream = client.GetStream();
            //    this.bSendServer.Enabled = true;
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show(exp.Message);
            //}
        }
            private void bSendServer_Click(object sender, EventArgs e)
        {

            try
            {
                client = new TcpClient(IP, port); // по айпи и порту подключаемся к сети
                stream = client.GetStream();
                this.bSendServer.Enabled = true;

                /* клиент отправляет запрос*/
                byte[] bytesRequest = Encoding.UTF8.GetBytes(request); // преобразование запроса сервера в байты
            stream.Write(bytesRequest, 0, bytesRequest.Length); //записываем в поток наши байты
            stream.Flush();   //  передаём их
            /*--------------------------------------------*/

            /* клиент получает ответ */
            byte[] getBytes = new byte[1024];
            int realBytesSize = stream.Read(getBytes, 0, getBytes.Length); // считываем данные полученные с сервера

            string answer = Encoding.UTF8.GetString(getBytes, 0, realBytesSize);
            this.tGetClient.Text = answer; 

            client.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void bChoiseObject_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fbd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                request = fbd.SelectedPath;
                tChoiseUser.Text = request; 
            }
        }
    }
}
