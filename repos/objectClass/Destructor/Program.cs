using System;

namespace Destructor
{
    public class customer
    {
        public customer()
        {
            Console.WriteLine("Defalut Constructor");
        }
        ~customer()
        {
            Console.WriteLine("Destructor Invoked");//Destructor  will not applicable for any  access modifiers

        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                customer c = new customer();


            }
        }
    }

