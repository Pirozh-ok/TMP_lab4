using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
                // создание сервера                
                string message = "START SERVER"; // что передаёт сервер
                const int port = 8080; // порт
                TcpListener serverSocket = new TcpListener(IPAddress.Any, port); // создаём сокет
                serverSocket.Start(); // запускаем сервер

                while (true)
                {
                    if (message == "EXIT") // если передана команда отключения, то останавливаем работу сервера
                        break;

                    TcpClient clientSocket = serverSocket.AcceptTcpClient();
                    NetworkStream stream = clientSocket.GetStream();

                    /* сервер получает и обрабатывает запрос клиента */
                    byte[] getBytes = new byte[256];
                    int realBytesSize = stream.Read(getBytes, 0, getBytes.Length);
                    string request = Encoding.ASCII.GetString(getBytes, 0, realBytesSize);
                    // вывод ответа сервера
                    /*---------------------------------*/

                /* сервер отвечает на запрос клиента */
                    byte[] bytesMessage = Encoding.ASCII.GetBytes(message); // преобразование сообщения сервера в байты
                    stream.Write(bytesMessage, 0, bytesMessage.Length); //записываем в поток наши байты
                    stream.Flush();   //  передаём их
                    clientSocket.Close();  // закрываем сокет 
                /*----------------------------------------*/
                }

                serverSocket.Stop(); // останавливаем сервер
        }
    }
}
