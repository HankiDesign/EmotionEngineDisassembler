﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MULTU : RegisterBase
    {
        public MULTU(string rs, string rt, string rd, string sa, string funct) 
            : base("MULTU", rs, rt, rd, sa, funct)
        {
        }
    }
}
