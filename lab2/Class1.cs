﻿using System;

namespace VL2
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException() : base() { }
        public RomanNumberException(string message) : base(message) { }
    }
}
