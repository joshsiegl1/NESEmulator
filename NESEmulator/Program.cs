using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NESEmulator.CPU; 

namespace NESEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU.CPU cpu = new CPU.CPU();

            //cpu.set_c_flag();

            //cpu.set_n_flag(); 

            cpu.setStatusFlag(CPU.CPU.StatusFlag.C);
            cpu.setStatusFlag(CPU.CPU.StatusFlag.N);
            cpu.clearStatusFlag(CPU.CPU.StatusFlag.N); 
            cpu.setStatusFlag(CPU.CPU.StatusFlag.I);
            cpu.clearStatusFlag(CPU.CPU.StatusFlag.I);

            byte byteData = 4 << 2;
            byte secondByte = 234;
            byte thirdByte = 1;
            //Console.WriteLine(byteData.ByteToString());
            //Console.WriteLine(secondByte.ByteToString());
            //Console.WriteLine(thirdByte.ByteToString());

            Console.WriteLine(cpu.StatusRegister.ByteToString());
            if (cpu.isFlagSet(CPU.CPU.StatusFlag.N))
                Console.WriteLine("N is set");  

            Console.ReadKey(); 
        }
    }
}
