﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakStatement
{
    internal class Program
    {
        static void Main(string[] args)

        {

            for (int i = 0; i <= 10; i++)
            {
                if (i == 7)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
