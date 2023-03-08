using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main()
        {
            // Variables
            string heightStr, radiusStr;
            float height, radius, vol, supArea;

            // Ask the user for height and radius
            Console.Write("Height is: ");
            heightStr = Console.ReadLine();

            Console.Write("Radius is: ");
            radiusStr = Console.ReadLine();

            // Convert height and radius string to float
            height = float.Parse(heightStr);
            radius = float.Parse(radiusStr);

            // Calculate volume
            vol = (float)Math.PI * (float)Math.Pow(radius, 2) * height;

            // Calculate superficial area
            supArea = 2 * (float)Math.PI * radius * (radius + height);

            // Show volume and superficial area
            Console.WriteLine($"Volume is: {vol:f2}");
            Console.WriteLine($"Superficial area is: {supArea:f2}");
        }
    }
}
