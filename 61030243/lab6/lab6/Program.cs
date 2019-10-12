using System;
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
            try
            {
                double d = 5e9d;
                Console.WriteLine(d);
                int i = checked((int)d);
                Console.WriteLine(i);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("than value");
            }
        }
    }
}
