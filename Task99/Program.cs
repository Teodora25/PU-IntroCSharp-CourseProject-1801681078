using System;
using System.Text;

namespace Task99
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float result1 = 0f;
            bool sign = false;


            for (float i = 1; i <= 100000; i++)
            {
                if (sign == false)
                {
                    result1 = result1 + (1 / i);
                    sign = true;
                }
                else
                {
                    result1 = result1 - (1 / i);
                    sign = false;
                }
            }

            Console.WriteLine("Резултат 1 = " + result1);

            //..............................................................................................
            float result2 = 0;
            sign = true;

            for (float i = 100000; i >= 1; i--)
            {
                if (sign == false)
                {
                    result2 = result2 + (1 / i);
                    sign = true;
                }
                else
                {
                    result2 = result2 - (1 / i);
                    sign = false;
                }
            }

            Console.WriteLine("Резултат 2 = " + result2);

            //...................................................................................................

            float result3 = 0, result = 0;

            for (float i = 1; i <= 100000; i+=2)
                result = result + (1 / i);

            for (float i = 2; i <= 100000; i += 2)
                result3 = result3 + (1 / i);

            result = result - result3;

            Console.WriteLine("Резултат 3 = " + result);

            //...................................................................................................

            result3 = 0; result = 0;

            for (float i = 99999; i >= 1; i -= 2)
                result = result + (1 / i);

            for (float i = 100000; i >= 2; i -= 2)
                result3 = result3 + (1 / i);

            result = result - result3;

            Console.WriteLine("Резултат 4 = " + result);
        }
    }
}
