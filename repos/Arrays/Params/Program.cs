using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        public static void objectParams(params object[] nums)// here we are using object type so it will allow any number of parameters in any datatype like string,int,double...

        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            }
        static void Main(string[] args)
        {
            Program.objectParams("Jhansi",112,11.50,"Loki",'h');
        }
    }
}
