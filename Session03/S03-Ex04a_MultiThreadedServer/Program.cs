namespace S03_Ex04a_MultiThreadedServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.Start();
        }
    }
}