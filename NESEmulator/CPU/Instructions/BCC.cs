using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESEmulator.CPU.Instructions
{
    public class BCC : Instruction
    {
        /// <summary>
        /// If the carry flag is clear then add the relative displacement
        /// to the program counter to cause a branch to a new location.
        /// </summary>
        /// <param name="OpCode"></param>
        public BCC(string OpCode)
            : base (OpCode)
        {
            switch (OpCode)
            {
                case "90":
                    this.addressingmode = AddressingMode.Relative;
                    this.cycles = 2; //+1 if branch succeeds +2 if to a new page
                    bytes = new byte[2];
                    break; 
            }
        }
    }
}
