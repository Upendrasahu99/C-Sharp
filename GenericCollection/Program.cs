using System;

namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();
            list.LinkedListPr();
            Console.WriteLine();

            MyStack stack = new MyStack();
            stack.MystackPr();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
