﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;   // do not initial value
            refMethod(out val);
            Console.WriteLine(val);
            Console.ReadLine();
        }

        static void refMethod(out int i)
        {
            i = i + 1;
        }
    }
}
