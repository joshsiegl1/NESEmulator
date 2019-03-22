using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NESEmulator.CPU.Instructions; 

namespace NESEmulator.CPU
{
    public static class InstructionFactory
    {
        public static Instruction Get(string OpCode)
        {
            switch (OpCode)
            {
                case "69":
                case "65":
                case "75":
                case "6D":
                case "7D":
                case "79":
                case "61":
                case "71":
                    return new ADC(OpCode);
                case "29":
                case "25":
                case "35":
                case "2D":
                case "3D":
                case "21":
                case "31":
                    return new AND(OpCode); 
                case "EA":
                    return new NOP(OpCode); 
            }

            return new NOP(OpCode); 
        }
    }
}
