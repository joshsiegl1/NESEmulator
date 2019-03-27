using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESEmulator.CPU.Instructions
{
    /// <summary>
    /// This operation shifts all the bits of the accumulator or memory 
    /// contents one bit left. Bit 0 is set to 0 and bit 7 is placed in the 
    /// carry flag. The effect of this operation is to multiply the memory 
    /// contents by 2 (ignoring 2's complement considerations), setting 
    /// the carry if the result will not fit in 8 bits.
    /// </summary>
    public class ASL : Instruction
    {
        public ASL(string OpCode) 
            : base(OpCode)
        {
            switch (OpCode)
            {
                case "0A":
                    this.addressingmode = AddressingMode.Accumulator;
                    this.cycles = 2;
                    bytes = new byte[1];
                    break;
                case "06":
                    this.addressingmode = AddressingMode.ZeroPage;
                    this.cycles = 5;
                    bytes = new byte[2];
                    break;
                case "16":
                    this.addressingmode = AddressingMode.ZeroPageX;
                    this.cycles = 6;
                    bytes = new byte[2];
                    break;
                case "0E":
                    this.addressingmode = AddressingMode.Absolute;
                    this.cycles = 6;
                    bytes = new byte[3];
                    break;
                case "1E":
                    this.addressingmode = AddressingMode.AbsoluteX;
                    this.cycles = 7;
                    bytes = new byte[3];
                    break; 
            }
        }
    }
}
