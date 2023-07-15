using System;

namespace methodGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Variable variable = new Variable();
            variable.printValue(4);
            variable.printValue("Raj");
            variable.printValue(6.4);
        }
    }
}
