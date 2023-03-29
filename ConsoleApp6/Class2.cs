using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Method m=new Method();
            Console.WriteLine(m.Add(10, 20));
            Console.WriteLine(m.Sub(10, 20));
            Console.WriteLine(m.Mod(100, 10));
            Console.WriteLine(m.Mul(10, 20));
            m.test(2);
        }
    }
}
