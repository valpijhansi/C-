using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee(13,"Jhansi",40000);
            e1.display(); 

            e.id = 12;
            e.name = "Lokesh"; 
            e.salary = 2000;
            e.display();

           


        }
    }
}
