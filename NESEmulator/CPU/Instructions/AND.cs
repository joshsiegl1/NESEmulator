using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESEmulator.CPU.Instructions
{
    public class AND : Instruction
    {
        /// <summary>
        ///A logical AND is performed, bit by bit, on the accumulator contents 
        ///using the contents of a byte of memory.
        /// </summary>
        /// <param name="OpCode"></param>
        public AND(string OpCode)
            : base(OpCode)
        {

            switch (OpCode)
            {
                case "29":
                    this.addressingmode = AddressingMode.Immediate;
                    this.cycles = 2;
                    bytes = new byte[2];
                    break;
                case "25":
                    this.addressingmode = AddressingMode.ZeroPage;
                    this.cycles = 3;
                    bytes = new byte[2];
                    break;
                case "35":
                    this.addressingmode = AddressingMode.ZeroPageX;
                    this.cycles = 4;
                    bytes = new byte[3];
                    break;
                case "2D":
                    this.addressingmode = AddressingMode.Absolute;
                    this.cycles = 4;
                    bytes = new byte[3];
                    break;
                case "3D":
                    this.addressingmode = AddressingMode.AbsoluteX;
                    this.cycles = 4;
                    bytes = new byte[3];
                    break;
                case "39":
                    this.addressingmode = AddressingMode.AbsoluteY;
                    this.cycles = 4;
                    bytes = new byte[3];
                    break;
                case "21":
                    this.addressingmode = AddressingMode.IndirectX;
                    this.cycles = 6;
                    bytes = new byte[2];
                    break;
                case "31":
                    this.addressingmode = AddressingMode.IndirectY;
                    this.cycles = 5;
                    bytes = new byte[2];
                    break;
            }
        }
    }
}