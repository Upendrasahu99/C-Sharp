using System;

namespace LinkedList
{
    internal class Program
    {
        class Node
        {
            public int data;  // data we enter
            public Node next; // reference to next node...

            public Node(int data)
            {
                this.data = data; // when we create node object node created where dat and next reference null store.
                next = null;
            }
        }

        class LinkedList
        {
            Node head = null;
            int count;

            public LinkedList() 
            {
                head = null;
                count = 0;
            }
            
            public void AddNodeToFront(int data)
            {
                Node node = new Node(data);
                node.next = head;
                head = node;
                count++; 
            }
            
            public void PrintList()
            {
                Node runner = head;
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
        }

        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNodeToFront(5);
            linkedList.AddNodeToFront(10);
            linkedList.PrintList();
            Console.ReadLine();
        }
    }
}
