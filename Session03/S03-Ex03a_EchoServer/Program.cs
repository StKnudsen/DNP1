using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace S03_Ex03_EchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hamsters, start the server..");
            
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();
            
            Console.WriteLine("The hamsters have started the server..");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                
                Console.WriteLine("   Client connected");
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
}