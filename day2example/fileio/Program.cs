using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileio
{
    class Program
    {
        static void Main(string[] args)
        {
            readwrite rw = new readwrite();
            rw.WriteFile(@"c:\Files\test.txt");
            rw.readfile(@"c:\Files\test.txt");
        }
    }
}
