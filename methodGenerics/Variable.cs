using System;
using System.Collections.Generic;
using System.Text;

namespace methodGenerics
{
    internal class Variable
    {
        public void printValue<T>(T input)
        {
            
            Console.WriteLine(input);

        }
    }
}
