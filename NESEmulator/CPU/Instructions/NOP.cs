using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESEmulator.CPU.Instructions
{
    public class NOP : Instruction
    {
        /// <summary>
        /// The NOP instruction causes no changes to the processor other than the normal 
        /// incrementing of the program counter to the next instruction.
        /// </summary>
        /// <param name="OpCode"></param>
        public NOP(string OpCode)
            : base(OpCode)
        {

            switch (OpCode)
            {
                case "EA":
                    this.addressingmode = AddressingMode.Implied;
                    this.cycles = 2;
                    bytes = new byte[1];
                    break;
            }
        }
    }
}
