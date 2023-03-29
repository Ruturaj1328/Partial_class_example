using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public partial class Method
    {

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        partial void Sq(int a)
        {
            Console.WriteLine(a*a);
        }
        public void test(int a)
        {
            Sq(a);
        }
    }
}
