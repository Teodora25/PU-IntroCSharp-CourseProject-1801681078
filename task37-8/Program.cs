using System;
using System.Text;

namespace task37_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float x = 1, y = 1, a = 1, z = 1;
            bool bx = false;

          bx = Math.Sqrt((x + 1 - a * y * y) / (y + x))>0 || Math.Exp(y)<(z-1) && Math.Sqrt(z-1)<=5;

            Console.WriteLine("Стойността на израза е: "+bx);
        }
    }
}
