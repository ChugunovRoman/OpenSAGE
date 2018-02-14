﻿using System.Numerics;
using System.Runtime.InteropServices;
using OpenSage.Mathematics;

namespace OpenSage
{
    [StructLayout(LayoutKind.Explicit)]
    public struct GameMessageArgumentValue
    {
        [FieldOffset(0)]
        public int Integer;

        [FieldOffset(0)]
        public float Float;

        [FieldOffset(0)]
        public bool Boolean;

        [FieldOffset(0)]
        public uint ObjectId;

        [FieldOffset(0)]
        public Vector3 Position;

        [FieldOffset(0)]
        public Point2D ScreenPosition;
    }
}
