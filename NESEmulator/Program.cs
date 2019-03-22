using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteData = 4 << 2;
            byte secondByte = 234;
            byte thirdByte = 1;  
            Console.WriteLine(byteData.ByteToString());
            Console.WriteLine(secondByte.ByteToString());
            Console.WriteLine(thirdByte.ByteToString());
            Console.ReadKey(); 
        }
    }
}
