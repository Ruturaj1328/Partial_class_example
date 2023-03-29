using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public partial class Method
    {
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Mod(int a, int b)
        {
            return a % b;
        }
        partial void Sq(int a);
    }
}
