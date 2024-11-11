using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithList
{
    class StackList<T>
    {
        private List<T> stack;

        private int size = 100;

        public StackList()
        {
            stack = new List<T>();
            
        }
        public void Push(T x)
        {
            if (stack.Count >= size)
            {
                throw new StackOverflowException();
            }
            stack.Add(x);
        }
        public void Pop()
        {
            if (stack.Count == 0)
            {
                throw new StackEmptyException();
            }

            stack.RemoveAt(stack.Count - 1);
        }
        public T Peek()
        {
            if (stack.Count == 0)
            {
                throw new StackEmptyException();
            }

            return stack[stack.Count - 1];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StackList<int> stack = new StackList<int>();
                stack.Push(10);
                stack.Push(20);
                stack.Push(30);

                Console.WriteLine(" Top element: " + stack.Peek());

                stack.Pop();

                Console.WriteLine(" Top element after pop: " + stack.Peek());

                stack.Pop();
                stack.Pop();
                stack.Pop();
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
    }
}
