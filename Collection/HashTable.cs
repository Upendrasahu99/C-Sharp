using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    internal class HashTable
    {
        public void MyQueuePractice()
        {
             Hashtable ht = new Hashtable();
            ht.Add("rrr", "ds");
            ht.Add('t', 6);
            ht.Add(8, "raj");
            ht.Add('p', "tttt");
           
           
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
        }
    }
}
