﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PXOR : RegisterBase
    {
        public PXOR(uint rs, uint rt, uint rd, uint sa) 
            : base("PXOR", rs, rt, rd, sa)
        {
        }
    }
}
