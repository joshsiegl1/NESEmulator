using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESEmulator
{
    public static class ExtensionMethods
    {
        public static string ByteToString(this byte a)
        {
            return Convert.ToString(a, 2).PadLeft(8, '0');
        }
    }
}
