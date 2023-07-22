using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection
{
    internal class MyLinkedList
    {
         public void LinkedListPr()
        {
            LinkedList<String> list = new LinkedList<String>();
            list.AddFirst("aa");
            list.AddFirst("bb");
            list.AddFirst("cc");
            list.AddLast("dd");
            
            foreach (String s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(list.Count);
        }
    }
}
