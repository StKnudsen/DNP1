using System;
using System.Net.Sockets;
using System.Text;

namespace S03_Ex05a_ChatServer
{
    public class ServerSocketHandler
    {
        private NetworkStream Stream;
        
        public void Run(TcpClient client, Server server)
        {
            Stream = client.GetStream();

            server.BroadCastMessage += OnReceiveMessage;

            string s = "";
            while (!s.Equals("exit"))
            {
                //  Read
                byte[] dataFromClient = new byte[1024];
                int bytesRead = Stream.Read(dataFromClient, 0, dataFromClient.Length);
                s = Encoding.UTF8.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine($"      {s}");
                
                server.BroadCastMessage.Invoke(s);
            }
                
            //  Close connection
            Console.WriteLine("   Client disconnected");
            client.Close();
        }

        private void OnReceiveMessage(string message)
        {
            byte[] dataToClient = Encoding.UTF8.GetBytes($"      Returning {message}");
            Stream.Write(dataToClient, 0, dataToClient.Length);
        }
    }
}