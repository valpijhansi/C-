using System;

namespace OOPSConcepts
{
    public class Car
    {
        public void run()
        {
            Console.WriteLine("the car is running");
        }
        
    }
    public class Bmw : Car
    {
        public void engineStatus()
        {
            Console.WriteLine("the status of enginee is not in active state");
        }
    }
}
