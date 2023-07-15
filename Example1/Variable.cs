using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
     class Variable <T>
    { 
        public void PrintInput(T input)
        {
            Console.WriteLine(input);
        }
    }
}
