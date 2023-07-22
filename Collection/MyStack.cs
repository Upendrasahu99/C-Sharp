using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    internal class MyStack
    {
        public void StackPractice()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push('r');
            stack.Push("Tata");
            foreach (object i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
