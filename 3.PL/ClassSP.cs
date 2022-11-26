using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PL
{
    internal static class ClassSP
    {
       public static string AutoID(string x, int y)
       {
            if (y == 0) return x + 1;
            else return x + (y + 1);
       }
    }
}
