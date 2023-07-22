using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCollection
{
    internal class MyStack
    {
        public void MystackPr()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);  
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Count);
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
