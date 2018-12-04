using System;
using System.Text;

namespace Task353
{
    class Program
    {
        static int Read(int x, int y)
        {
            bool f;
            int num;
            do
            {
                Console.Write("Въведете число в интервала ["+x+";"+y+"] : ");
                f = int.TryParse(Console.ReadLine(), out num);
            }
            while (!f || num < x || num > y);

            return num;
        
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Въведете x: ");
           int x = int.Parse(Console.ReadLine());
            Console.Write("Въведете y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(Read(x, y));
            
        }
    }
}
