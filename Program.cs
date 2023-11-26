using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5;
            b = 7;
            Console.WriteLine("befpre swaping");
            Console.WriteLine("a=" + a + "b=" + b);
            Console.WriteLine("after swaping");
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a=" + a + "b=" + b);
        }
    }
}
