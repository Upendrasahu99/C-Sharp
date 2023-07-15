using System;
using System.Numerics;

namespace Generic
{
    internal class Variable
    {
        static void Main(string[] args)
        {
            Variable<int> intType = new Variable<int>();
            intType.PrintInput(6);

            Variable<String> stringType =  new Variable<String>();
            stringType.PrintInput("Tata");

            Variable<bool> boolType = new Variable<bool>();
            boolType.PrintInput(true);

            Variable<double> doubleType = new Variable<double>();
            doubleType.PrintInput(5.4);

            Console.WriteLine();
        }
    }
}
