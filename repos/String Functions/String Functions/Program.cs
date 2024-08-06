using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(str);
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Length);
            
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            string name=fName+lName;
            Console.WriteLine(name);

            string s = string.Concat(fName,lName);
            Console.WriteLine(s.ToUpper());

            string firstName = "John";
            string lastName = "Doe";
            string name1 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name1);
        }
    }
}
