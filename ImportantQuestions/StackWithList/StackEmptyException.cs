using System;

namespace StackWithList
{
    public class StackEmptyException : Exception
    {
        public StackEmptyException() : base("Stack is empty") { }

        public StackEmptyException(string message) : base(message) { }
    }
}
