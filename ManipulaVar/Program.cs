using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);

            int a = 1, b;
            b = a++ + x++; // a=2, x=input=2, b=2

            Console.WriteLine($"O resultado da operação é {b}.");
            Console.WriteLine($"O valor de A é {a}.");
            Console.WriteLine($"O valor de X é {x}.");
        }
    }
}
