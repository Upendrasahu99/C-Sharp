using System;

namespace LinkedList
{
    internal class Program
    {
        class Node
        {
            public int data;  // data we enter
            public Node next; // reference to next node...

            public Node(int data)// Create node 

            {
                this.data = data; // when we create node object node created where dat and next reference null store.
                next = null;
            }
        }
        class LinkedList
        {
            Node head;
            int count; // number of nodes

            public LinkedList()
            {
                head = null;
                count = 0;
            }
            
            public void AddLast(int data)
            {
                Node newNode = new Node(data);
                count++;
                newNode.next
                if(head == null)
                {
                    head = node;

                }
            }
        }

        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
    }
}
