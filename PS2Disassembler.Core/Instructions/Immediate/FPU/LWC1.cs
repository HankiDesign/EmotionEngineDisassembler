﻿namespace PS2Disassembler.Core.Instructions.Immediate.FPU
{
    public class LWC1 : ImmediateBase
    {
        public LWC1(int rs, int rt, int imm) : base("LWC1", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base, RT = FT
        }
    }
}
