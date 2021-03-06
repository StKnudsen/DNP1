using System;
using System.Net.Sockets;
using System.Text;

namespace S03_Ex03b_EchoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hamsters is starting client..");

            TcpClient client = new TcpClient("127.0.0.1", 5000);

            NetworkStream stream = client.GetStream();

            string s = "";
            while (!s.Equals("exit"))
            {
                Console.WriteLine("Enter message: ");
                s = Console.ReadLine();
                
                byte[] dataToServer = Encoding.UTF8.GetBytes(s);
                stream.Write(dataToServer, 0, dataToServer.Length);
    
                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.UTF8.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine(response);
            }
            
            
            stream.Close();
            client.Close();
        }
    }
}