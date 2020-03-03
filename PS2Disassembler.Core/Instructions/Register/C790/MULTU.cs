﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MULTU : RegisterBase
    {
        public MULTU(int rs, int rt, int rd, int sa, int funct) 
            : base("MULTU", rs, rt, rd, sa, funct)
        {
        }
    }
}
