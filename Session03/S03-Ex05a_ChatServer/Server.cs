using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace S03_Ex05a_ChatServer
{
    public class Server
    {
        public Action<string> BroadCastMessage;
        
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

                ServerSocketHandler serverSocketHandler = new ServerSocketHandler();
                Thread thread = new Thread(() => serverSocketHandler.Run(client, this));
                thread.Start();
                Console.WriteLine("   New client connected..");
            }
        }
    }
}