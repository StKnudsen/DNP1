using System;

namespace S02_Ex04_DoctorsWaitingRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitingRoom wr = new WaitingRoom();
            
            Patient p1 = new Patient(wr);
            Patient p2 = new Patient(wr);
            Patient p3 = new Patient(wr);
            Patient p4 = new Patient(wr);
            
            wr.RunWaitingRoom();
        }
    }
}