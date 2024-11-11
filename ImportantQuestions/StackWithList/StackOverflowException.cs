using System;

namespace StackWithList
{
    public class StackOverflowException : Exception
    {
        public StackOverflowException() : base("Stack overflow") { }

        public StackOverflowException(string message) : base(message) { }
    }
}
