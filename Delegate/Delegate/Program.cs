using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate
{
    class Program
    {
        delegate void d1(int i);
        static void Main(string[] args)
        {
            d1 d = new d1(demo);
            d(1);
            Console.ReadLine();
        }

        private static void demo(int i)
        {
            Console.WriteLine(i.ToString());
        }
    }
}
