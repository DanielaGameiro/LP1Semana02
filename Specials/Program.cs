using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int max = {int.MaxValue}");
            Console.WriteLine($"int min = {int.MinValue}");

            Console.WriteLine($"long max = {long.MaxValue}");
            Console.WriteLine($"long min = {long.MinValue}");

            Console.WriteLine($"short max = {short.MaxValue}");
            Console.WriteLine($"short min = {short.MinValue}");

            Console.WriteLine($"sbyte max = {sbyte.MaxValue}");
            Console.WriteLine($"sbyte min = {sbyte.MinValue}");

            Console.WriteLine($"byte max = {byte.MaxValue}");
            Console.WriteLine($"byte min = {byte.MinValue}");

            Console.WriteLine($"ushort max = {ushort.MaxValue}");
            Console.WriteLine($"ushort min = {ushort.MinValue}");

            Console.WriteLine($"uint max = {uint.MaxValue}");
            Console.WriteLine($"uint min = {uint.MinValue}");

            Console.WriteLine($"ulong max = {ulong.MaxValue}");
            Console.WriteLine($"ulong min = {ulong.MinValue}");

            Console.WriteLine($"float max = {float.MaxValue}");
            Console.WriteLine($"float min = {float.MinValue}");

            Console.WriteLine($"double max = {double.MaxValue}");
            Console.WriteLine($"double min = {double.MinValue}");

            Console.WriteLine($"decimal max = {decimal.MaxValue}");
            Console.WriteLine($"decimal min = {decimal.MinValue}");

            Console.WriteLine($"float +inf = {float.PositiveInfinity}");
            Console.WriteLine($"float -inf = {float.NegativeInfinity}");
            Console.WriteLine($"float Nan = {float.NaN}");

            Console.WriteLine($"double +inf = {double.PositiveInfinity}");
            Console.WriteLine($"double -inf = {double.NegativeInfinity}");
            Console.WriteLine($"double Nan = {double.NaN}");

            byte b = byte.MaxValue;
            Console.WriteLine($"byte max = {b}");
            b++;
            Console.WriteLine($"byte max +1 = {b}");

            short s = short.MinValue;
            Console.WriteLine($"short min = {s}");
            s--;
            Console.WriteLine($"short min -1 = {s}");

            float fMax = (float.MaxValue);
            Console.WriteLine(fMax * 2);

            double dMax = (double.MaxValue);
            Console.WriteLine($"double max = {double.MaxValue}");
            Console.WriteLine(dMax + 1);

            float f1, f2;
            f1 = f2 = 10.0f;
            Console.WriteLine(f1 == f2 + 0.0000001f);

            double d1, d2;
            d1 = d2 = 10.0f;
            Console.WriteLine(d1 == d2 + 0.0000001);
        }
    }
}
