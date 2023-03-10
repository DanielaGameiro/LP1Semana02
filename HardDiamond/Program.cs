using System;

namespace HardDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int item;

            if (int.TryParse(args[0], out item))
            {
                if (item % 2 == 1)
                {
                    for (int i = 0; i < item; i++)
                    {
                        int middle = item / 2;
                        int difference = Math.Abs(i - middle);

                        for (int j = 0; j < item; j++)
                        {
                            if (difference + Math.Abs(j - middle) <= middle)
                                Console.Write(".");
                            
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                    Console.WriteLine("I only want odd items!");
            }
        }
    }
}
