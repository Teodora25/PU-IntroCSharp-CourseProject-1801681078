using System;

namespace Task200
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5;
            float b = 2;
            float c = 3;
            float d = 7;
            float e = 4;
            float f = 6;
            float x, y;

            float det = a * e - b * d;
            float det1 = c * e - b * f;
            float det2 = a * f - c * d;

            x = det1 / det;
            y = det2 / det;

            Console.WriteLine("x = "+x);
            Console.WriteLine("y = "+y);

        }
    }
}
