using System;
using static functions.functions.Program;

namespace functions
{
    internal partial class Program
    {
        public void display(int value)
        {
            value = value * 10;
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            /*int value = int.Parse(Console.ReadLine());
            Program program = new Program();
            program.display(value);*/

          
            //var p = new Point(1,2);  
           // Program p1 = new Program();
           // UsePoints();
            int number = 10;
            var p =  int.TryParse("abc",out number);
            if (p)
            {
                Console.WriteLine(number);
            }
            else
            {

            Console.WriteLine("Conversion Failed"); 
            }
           // Console.WriteLine(number);
            








        }
        static void useParams()
        {
            var c = new calculator();
            Console.WriteLine(c.ADD(1, 2, 3));//with help of params we can assign values without using an array also
            Console.WriteLine(c.ADD(1, 2));
            Console.WriteLine(new int[] { 1, 2, 3, });

        }
        static void UsePoints()
        {
            try
            {

                var p = new Point(10, 20);
                p.move(new Point(20, 10));
                Console.WriteLine("Point moves at({0},{1})", p.X, p.Y);
                p.move(20, 30);
                Console.WriteLine("Point moves at({0},{1})", p.X, p.Y);
            }
            catch (Exception)
            {

                new Exception("An invalid error occured");
            }
        }
    }
}
