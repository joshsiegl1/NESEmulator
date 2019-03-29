using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESEmulator.CPU.Instructions
{
    /// <summary>
    /// If the zero flag is clear then add the relative displacement 
    /// to the program counter to cause a branch to a new location.
    /// </summary>
    public class BNE : Instruction
    {
        public BNE(string OpCode)
            : base (OpCode)
        {
            switch (OpCode)
            {
                case "D0":
                    this.addressingmode = AddressingMode.Relative;
                    this.cycles = 2; //+1 if branch succeeds +2 if to a new page
                    bytes = new byte[2]; 
                    break; 
            }
        }
    }
}
