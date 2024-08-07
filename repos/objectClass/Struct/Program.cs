using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    //just like class struct is also one of the blueprint .
    //It used to create an instance of the class
    public struct Area
    {

    public int x; public int y; 
    }
    internal class Program
    {
        static void Main(string[] args)

        {
            Area area = new Area();
            area.x = 30;
            area.y = 3;
            int res = area.x * area.y;
            Console.WriteLine("the area is: " + res);
        }
    }
}
