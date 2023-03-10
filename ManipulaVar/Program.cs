using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);
            int y = x;

            int a = 1, b;
            b = a++ + x++; 

            Console.WriteLine("");
            Console.WriteLine($"O resultado da operação é {b}.");
            Console.WriteLine($"O valor de A é {a}.");
            Console.WriteLine($"O valor de X é {x}.");

            int c = 1, d;
            d = c++ + --y;

            Console.WriteLine("");
            Console.WriteLine($"O resultado da operação é {d}.");
            Console.WriteLine($"O valor de C é {c}.");
            Console.WriteLine($"O valor de X é {y}.");
        }
    }
}
