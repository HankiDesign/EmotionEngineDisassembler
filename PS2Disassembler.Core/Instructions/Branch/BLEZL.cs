﻿namespace PS2Disassembler.Core.Instructions.Branch
{
    public class BLEZL : BranchBase
    {
        public BLEZL(string rs, string rt, short offset) : base("BLEZL", rs, rt, offset)
        {
        }
    }
}
