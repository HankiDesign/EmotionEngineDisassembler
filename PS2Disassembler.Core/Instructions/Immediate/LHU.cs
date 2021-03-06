﻿namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LHU : ImmediateBase
    {
        public LHU(uint rs, uint rt, uint imm) : base("LHU", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
