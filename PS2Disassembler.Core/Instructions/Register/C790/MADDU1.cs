﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MADDU1 : RegisterBase
    {
        public MADDU1(uint rs, uint rt, uint rd, uint sa) 
            : base("MADDU1", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
            //return $"{OP} {RD}, {RS}, {RT}"; TODO: ???
        }
    }
}
