﻿using System;
using System.Runtime.InteropServices;

namespace hmitype
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct nameidtypecrc
    {
        public uint crc;

        public ushort id;
    }
}
