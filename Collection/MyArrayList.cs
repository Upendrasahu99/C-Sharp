using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    internal class MyArrayList
    {
        public void ArrayListPractice() 
        {
            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add('r');
            a1.Add("Jay");
            a1.RemoveAt(1);
            
            foreach (object i in a1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
