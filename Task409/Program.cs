using System;
using System.Text;

namespace Task409
{
    class Program
    {
        static void Input(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static float Average7(int[] a)
        {
            float sum = 0, b = 0, average7;
            for (int i = 0; i < a.Length; i++)
            {
             if(a[i]%7==0)
                {
                    sum = sum + a[i];
                    b++;
                }
            }
            if (b == 0) return average7 = 0;
            return average7 = sum / b;

        }
                static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            float avr1 = 0, avr2 = 0, avr3 = 0;
            Console.Write("Въведете размер на масива n = ");
            n = int.Parse(Console.ReadLine());

           // Console.WriteLine("Числото n е: "+n);

            int[] A = new int[n];
            Input(A);
            avr1 = Average7(A);
            Console.WriteLine("Средно аритметично: " + avr1);

            int[] B = new int[n];
            Input(B);
            avr2 = Average7(B);
            Console.WriteLine("Средно аритметично: " + avr2);

            int[] C = new int[n];
            Input(C);
            avr3 = Average7(C);
            Console.WriteLine("Средно аритметично: " + avr3);

            float[] avr = { avr1, avr2, avr3 };

            for (int i = 1; i<avr.Length; i++)
                for (int j = avr.Length-1; j>=i; j--)
                    if (avr[j-1]>avr[j])
                    { float x = avr[j - 1];
                        avr[j - 1] = avr[j];
                        avr[j] = x;
                    }
            Console.WriteLine("Най-малко средно аритметично: " + avr[0]);
            Console.WriteLine();

            int k = 0;
            for (int i = n-1; i>=0; i--)
            {
             C[k] = A[i] - (n - k-1) * B[k];

            Console.Write("C[" + k + "] = "+ C[k]);
            Console.WriteLine();
                k++;
            }
        }
    }
}