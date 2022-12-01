using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PL.Utilities
{
    public class Utility
    {
        // Check là số
        public static bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static bool CheckStringEmpty(string x)
        {
            if(x == String.Empty)
            {
                return true;
            }
            else return false;
        }
    }
}
