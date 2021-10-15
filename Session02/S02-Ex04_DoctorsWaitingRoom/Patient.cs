using System;

namespace S02_Ex04_DoctorsWaitingRoom
{
    public class Patient
    {
        private int numberInQueue;
        public WaitingRoom wr; 
        
        public Patient(WaitingRoom wr)
        {
            this.wr = wr;
            wr.NumberChange += ReactToNumber;
            numberInQueue = wr.DrawNumber();
            Console.WriteLine($"Patient {numberInQueue} enters waiting room");
        }

        public void ReactToNumber(int ticketNumber)
        {
            string patient = $"Patient {numberInQueue} ";
            Console.WriteLine($"{patient} looks up");
            
            if (ticketNumber == numberInQueue)
            {
                Console.WriteLine($"{patient} enters the doctor's room"); 
                wr.NumberChange -= ReactToNumber;
            }
            else
            {
                Console.WriteLine($"{patient} goes back to looking at phone");
            }
        }
    }
}