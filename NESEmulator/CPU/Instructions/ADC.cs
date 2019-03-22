using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESEmulator.CPU.Instructions
{
    /// <summary>
    ///  This instruction adds the contents of a memory location to the accumulator together with
    ///  the carry bit. If overflow occurs the carry bit is set, this enables multiple byte 
    ///  addition to be performed.
    /// </summary>
    public class ADC : Instruction
    {
        public ADC(string OpCode)
            : base(OpCode)
        {
        
            switch (OpCode)
            {
                case "69":
                    this.addressingmode = AddressingMode.Immediate;
                    this.cycles = 2;
                    bytes = new byte[2]; 
                    break;
                case "65":
                    this.addressingmode = AddressingMode.ZeroPage;
                    this.cycles = 3;
                    bytes = new byte[2]; 
                    break;
            }
        }
    }
}
