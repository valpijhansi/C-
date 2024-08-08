using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add a = new add();  
            a.a = 1;
            a.b = 2;
            a.fName = "Lucky";
            a.lName = "Jaanu";
            a.concat(a.fName, a.lName);
            a.Add(a.a, a.b);
        }
    }
}
