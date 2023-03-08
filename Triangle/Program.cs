using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(args[0]);
            char character = char.Parse(args[1]);

            for (int row = 1; row <= numberOfLines; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(character);
                }

                Console.WriteLine();
            }
        }
    }
}



