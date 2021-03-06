﻿namespace PS2Disassembler.Core.Instructions.Immediate.Branch
{
    public class BEQL : BranchBase
    {
        public BEQL(uint rs, uint rt, uint offset) : base("BEQL", rs, rt, offset)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}, {Imm}";
        }
    }
}
