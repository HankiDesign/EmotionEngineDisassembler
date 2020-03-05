﻿namespace PS2Disassembler.Core.Instructions.Immediate.FPU
{
    public class SWC1 : ImmediateBase
    {
        public SWC1(int rs, int rt, int imm) : base("SWC1", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base, RT = FT
        }
    }
}
