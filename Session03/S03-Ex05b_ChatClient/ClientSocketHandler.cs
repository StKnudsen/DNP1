using System;
using System.Net.Sockets;
using System.Text;

namespace S03_Ex05b_ChatClient
{
    public class ClientSocketHandler
    {
        private NetworkStream Stream;
        
        public void Run(TcpClient client)
        {
            Stream = client.GetStream();

            //  Set up for receiving messages
            while (true)
            {
                byte[] dataFromServer = new byte[1024];
                int bytesRead = Stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.UTF8.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine(response);
            }
        }

        public void SendMessage(string message)
        {
            byte[] dataToServer = Encoding.UTF8.GetBytes(message);
            Stream.Write(dataToServer, 0, dataToServer.Length);

            if (message.Equals("exit"))
            {
                Stream.Close();
            }
        }
    }
}