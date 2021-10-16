using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace S03_Ex04a_MultiThreadedServer
{
    public class Server
    {
        public void Start()
        {
            Console.WriteLine("Hamsters, start the server..");
            
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();
            
            Console.WriteLine("The hamsters have started the server..");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();

                ServerHandler serverHandler = new ServerHandler();
                Thread thread = new Thread(() => serverHandler.RunServerHandler(client));
                thread.Start();
                Console.WriteLine("   New client connected..");
            }
        }
    }
}