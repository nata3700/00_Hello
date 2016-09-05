using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Hello
{
    class Functions
    {
        internal static string Hello()
        {
            return "hello";
        }

        internal static object Hello(string v)
        {
            return "hello, " + v;
        }
    }
}