using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public struct Days
    {
        
    }
    internal class Program
    {
        public enum days { SUN=12, MON, TUE, WED, THURSDAY, FRIDAY, };
        static void Main(string[] args)
        {
            int a = (int)days.SUN;
            int b = (int)days.MON;
            Console.WriteLine("sun={0}",a);
            Console.WriteLine("mon={0}",b);


          //  foreach (string s in Enum.GetName(typeof(days)))
            //{
                Console.WriteLine(s);
            //}
        }
    }
}
