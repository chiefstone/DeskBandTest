﻿#pragma warning disable 1591
using System;
using System.Runtime.InteropServices;

namespace WindowsDeskBand.DeskBand.Interop.Struct {
    [StructLayout(LayoutKind.Sequential)]
    public struct MSG
    {
        public IntPtr hwnd;
        public uint message;
        public uint wParam;
        public int lParam;
        public uint time;
        public POINT pt;
    }
}
