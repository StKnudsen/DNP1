using System;
using System.Net.Sockets;
using System.Threading;

namespace S03_Ex05b_ChatClient
{
    public class Client
    {
        public void Start()
        {
            Console.WriteLine("Hamsters is starting client..");

            TcpClient client = new TcpClient("127.0.0.1", 5000);

            

            ClientSocketHandler clientSocketHandler = new ClientSocketHandler();

            Thread thead = new Thread(() => clientSocketHandler.Run(client));
            thead.Start();

            string s = "";
            while (!s.Equals("exit"))
            {
                Console.WriteLine("Enter message: ");
                s = Console.ReadLine();
                
                clientSocketHandler.SendMessage(s);
            }
            
            client.Close();
        }
    }
}