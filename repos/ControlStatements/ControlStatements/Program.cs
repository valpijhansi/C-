using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        //Console.WriteLine(a);
        //int b = int.Parse(Console.ReadLine());
        //Console.WriteLine(b);


        if (a >= 90)
        {

            Console.WriteLine("A+ Grade");


        }
        else if (a <= 70 && a >= 60)
        {
            Console.WriteLine("A Grade");
        }
        else if (a <= 59 && a >= 45)
        {
            Console.WriteLine("B Grade");
        }
        else if (a <= 40 && a >= 30)
        {
            Console.WriteLine("C Grade");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}



