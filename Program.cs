using System;

namespace RecursionPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintName("Ritesh", 5);
            PrintFib(10);
            Console.ReadLine();
        }

        private static void PrintFib(int v)
        {
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            RecFib(n1, n2, v);
        }

        private static void RecFib(int n1, int n2, int v)
        {
            if (v == 2) return;
            else
            {
                Console.WriteLine(n1 + n2);
                int temp = n1;
                n1 = n2;
                n2 += temp ;

                
                v--;
                RecFib(n1, n2, v);

            }
        }

        private static void PrintName(string v, int times)
        {
            if (times == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(v);
                times -= 1;
                PrintName(v, times);
            }
        }
    }
}
