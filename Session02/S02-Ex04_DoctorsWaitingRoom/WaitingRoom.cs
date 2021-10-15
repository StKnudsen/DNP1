using System;
using System.Threading;

namespace S02_Ex04_DoctorsWaitingRoom
{
    public class WaitingRoom
    {
        public Action<int> NumberChange;
        private int currentNumber;
        private int ticketCount;

        public WaitingRoom()
        {
            currentNumber = 0;
            ticketCount = 0;
        }

        public void RunWaitingRoom()
        {
            while (currentNumber < ticketCount)
            {
                //Console.WriteLine($"\nPatient number {currentNumber} can now enter");
                Console.WriteLine($"\nDiing!");
                
                NumberChange.Invoke(currentNumber++);
                
                Thread.Sleep(1000);
            }
        }

        public int DrawNumber()
        {
            return ticketCount++;
        }
    }
}