using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESEmulator.CPU
{
    public class CPU
    {
        public enum StatusFlag
        {
            C = 0, 
            Z = 1, 
            I = 2, 
            D = 3, 
            B = 4, 
            BB = 5, 
            V = 6, 
            N = 7
        }

        private byte statusRegister; 
        public byte StatusRegister { get { return statusRegister; } }

        public void setStatusFlag(StatusFlag index)
        {
            statusRegister |= (byte)(1 << (int)index);
        }

        public void clearStatusFlag(StatusFlag index)
        {
            statusRegister &= (byte) ~(1 << (int)index); 
        }

        public bool isFlagSet(StatusFlag index)
        {
            return (statusRegister & (1 << (int)index)) != 0; 
        }

    }
}
