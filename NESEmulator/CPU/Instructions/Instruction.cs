using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESEmulator.CPU.Instructions
{
    public abstract class Instruction
    {
        public readonly string OpCode;

        public byte[] bytes;

        protected int cycles; 
        public int Cycles
        {
            get { return cycles; }
        }

        protected AddressingMode addressingmode;
        public AddressingMode addressingMode
        {
            get { return addressingmode; }
        }

        public Instruction(string OpCode)
        {
            this.OpCode = OpCode; 
        }

        public enum AddressingMode
        {
            Absolute,
            Accumulator,
            Implied,
            Relative,
            ZeroPage,
            ZeroPageX,
            Immediate,
            AbsoluteX,
            AbsoluteY,
            IndirectX,
            IndirectY
        }
    }
}
