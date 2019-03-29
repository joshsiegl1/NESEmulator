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

        public static byte setBit(this byte a, int index)
        {
            return a |= (byte)(1 << index); 
        }

        public static byte clearBit(this byte a, int index)
        {
            return a &= (byte)~(1 << index); 
        }

        public static bool isBitSet(this byte a, int index)
        {
            return (a & (1 << index)) != 0; 
        }
    }
}
