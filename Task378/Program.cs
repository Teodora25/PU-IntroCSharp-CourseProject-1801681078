using System;
using System.Text;

namespace Task378
{
    class Program { 
        static int Pro(int n) 
    {
            int p = 1;
        Random rand = new Random();
        for(int i = 0; i<n; i++)
        {
            int x = rand.Next(-20,20);
                if ((x >= -10) && (x <= 10))
                    p = p * x;
        }
            return p;

    }
    
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int k = 0, sum = 0;
            do
            {
                Console.Write("Въведете число != 0, за край 0: ");
                k = int.Parse(Console.ReadLine());
                if (k < 0) sum = sum + k;

            }while (k != 0);

            Console.WriteLine("Сумата на отрицателните числа е: "+sum);
            Console.WriteLine();

            //........................................................................................................................

            k = 0; sum = 0;
            float d = 0;
            for (int i = 1; i < 14; i++)
            {
                Console.Write("Въведете число " + i + " = ");
                k = int.Parse(Console.ReadLine());
                if ((k > 0) || (k < -100))
                {
                    sum = sum + k;
                    d = d + 1;
                }

            }

            Console.WriteLine("Средно аритметично: " + sum/d);
            Console.WriteLine();

            //..........................................................................................................................

            int proizvedenie = 0;
            int a, b, c;

            Console.Write("Въведете а = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Въведете b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Въведете c = ");
            c = int.Parse(Console.ReadLine());

            proizvedenie = Pro(Math.Abs(c-b))*Pro(a);

            Console.WriteLine("Произведение: "+proizvedenie);
        }
    }
}
