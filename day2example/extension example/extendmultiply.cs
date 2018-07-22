using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculatorlibrary;

namespace extension_example
{
   static class extendmultiply
    {
        public static int Mul(this Calculator c, int x, int y )
        {
            return (x * y);
        }
    }
}
