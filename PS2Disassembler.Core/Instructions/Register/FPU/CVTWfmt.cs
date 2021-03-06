﻿namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CVTWfmt : FPURegisterBase
    {
        public CVTWfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("CVTWfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"CVT.W.S {FD}, {FS}\n" +
                   $"CVT.W.D {FD}, {FS}";
        }
    }
}
