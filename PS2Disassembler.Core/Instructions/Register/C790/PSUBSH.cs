﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBSH : RegisterBase
    {
        public PSUBSH(string rs, string rt, string rd, string sa, string funct) 
            : base("PSUBSH", rs, rt, rd, sa, funct)
        {
        }
    }
}