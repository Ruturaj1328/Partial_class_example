using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Calculation c= new Calculation();
            Console.WriteLine(c.Add(10, 20));
            Console.WriteLine(c.Sub(10, 20));
            Console.WriteLine(c.Mod(100, 10));
            Console.WriteLine(c.Mul(10, 20));
            Console.WriteLine(c.div(20, 20));
        }
    }
}
