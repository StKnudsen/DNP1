using System;
using System.Net.Sockets;
using System.Text;

namespace S03_Ex04a_MultiThreadedServer
{
    public class ServerHandler
    {
        //private TcpClient Client;

        public void RunServerHandler(TcpClient client)
        {
            //Client = client;
            
            NetworkStream stream = client.GetStream();

            string s = "";
            while (!s.Equals("exit"))
            {
                //  Read
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                s = Encoding.UTF8.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine($"      {s}");
                    
                //  Respond
                byte[] dataToClient = Encoding.UTF8.GetBytes($"      Returning {s}");
                stream.Write(dataToClient, 0, dataToClient.Length);
            }
                
            //  Close connection
            Console.WriteLine("   Client disconnected");
            client.Close();
        }
    }
}