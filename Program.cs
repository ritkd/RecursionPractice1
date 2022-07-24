using System;
using System.Collections.Generic;

namespace RecursionPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintName("Ritesh", 5);
            PrintFib(10);
            int sum = 0;
            SumOfN(10, sum);
            sum = SUmOfNFunc(10);
            Console.WriteLine(PrintFact(5));
            int[] arr1 = { 1, 2, 3, 5, 7, 9 };
            RevArray(arr1, 0, arr1.Length-1);
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            bool isPalind = false;
            isPalind = IsPalindrome(0,"halaiialah");
            Console.WriteLine(isPalind);
            int fibNum = 0;
            fibNum = MultiFib(6);
            Console.WriteLine("kjdfapplekdjf");
            Console.WriteLine(SkipString("kjdfapplekdjf"));
            Console.WriteLine("kjdfapplekdjf");

            Console.WriteLine(SkipStringAppNotApple("kjdfapplekdjf"));
            Console.WriteLine("kjdfappkdjf");

            Console.WriteLine(SkipStringAppNotApple("kjdfappkdjf"));
            string op="";//= new List<string>();
            List<string> opList = new List<string>();

            SubsetsOfString(op,"abc");
            opList = SubsetsOfStringList(op, "abc");
            foreach (var item in opList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(fibNum);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        private static List<string> SubsetsOfStringList(string op, string v)
        {
            if (string.IsNullOrEmpty(v))
            {
                List<string> result = new List<string>();
                result.Add(op); 
                return result;
            }
            char ch = v[0];
            List<string> left =  SubsetsOfStringList(op + ch, v.Substring(1));
            List<string> right =  SubsetsOfStringList(op, v.Substring(1));
            left.AddRange(right);
            return left;
        }

        private static void SubsetsOfString(string op, string v)
        {
            if (string.IsNullOrEmpty(v)) { Console.WriteLine(op); return; }
            char ch = v[0];
            SubsetsOfString(op+ch, v.Substring(1));
            SubsetsOfString(op, v.Substring(1));
        }

        private static string SkipString(string v)
        {
            if (string.IsNullOrEmpty(v)) return "";
            if (v.StartsWith("apple")) return SkipString(v.Substring(5));
            else return v[0] + SkipString(v.Substring(1));
        }
        private static string SkipStringAppNotApple(string v)
        {
            if (string.IsNullOrEmpty(v)) return "";
            if (v.StartsWith("app") && !v.StartsWith("apple")) return SkipStringAppNotApple(v.Substring(3));
            else return v[0] + SkipStringAppNotApple(v.Substring(1));
        }

        private static int MultiFib(int v)
        {
            if (v <= 1) return v;
            int last = MultiFib(v - 1);
            int slast = MultiFib(v - 2);
            return last+slast;
        }

        private static bool IsPalindrome(int startPointer, string v)
        {
            if (startPointer >= v.Length / 2) return true;
            if (v[startPointer] != v[v.Length - startPointer - 1]) return false;
            return IsPalindrome(startPointer + 1, v);
        }

        private static void RevArray(int[] arr1, int start, int end)
        {
            if (start >= end) return;
            int temp = arr1[start];
            arr1[start] = arr1[end];
            arr1[end] = temp;
            RevArray(arr1,++start,--end);
        }

        private static int PrintFact(int v)
        {
            if (v == 1) return 1;
            return v * PrintFact(v - 1);
        }

        private static int SUmOfNFunc(int v)
        {
            if (v == 0)
                return 0 ;
            return (v + SUmOfNFunc(v - 1));
        }

        private static void SumOfN(int v, int s)
        {
            if (v == 0)
            {
                Console.WriteLine(s);
                return;
            }
            else
            {
                s += v;
                v--;
                SumOfN(v, s);
            }
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
