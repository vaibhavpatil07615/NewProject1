using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myprojectadvance.Collection.Assignment
{
    internal class Assignemnt22apr
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("enter string ");
            string s = Console.ReadLine();
            string op = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                op = op + s[i];

            }
            Console.WriteLine("reverse string = " + op);

        }


    }
    class Armstrong
    {
        public static void checknum(int n)
        {
            int sum = 0;
            int temp = n;
            while (n > 0)
            {
                int rem = n % 10;
                 sum = sum + rem * rem * rem;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("number is armstrong");
            }
            else Console.WriteLine("number is not armstrong");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to check armstrong or not");
            int num = int.Parse(Console.ReadLine());
            Armstrong.checknum(num);
        }
    }
    class Minnumber
    {
        public static void Min(int[] a)
        {
            int min = a[0]; 
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine($"minimum element from array is = {min}");
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine($"enter {arr.Length} element of array");

            for (int i = 0;i< arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Minnumber.Min(arr);
        }
    }
   /* class Primenumber
    {
        static bool isprime (int n)
        {
            if (n== 0 || n == 1){

                return false;
            }
            for (int i = 2;i< n; i++)
            {
                if (n%i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        static void Main(string[] args)
        {
            int N = 100;
            for (int i = 1; i<= N; i++)
            {
                if (isprime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }









        }*/
    

      /*  class Fibonacci
        {
            static void Main(string[] args)
            {
                int a = 1;
                int b = 1;
                Console.WriteLine(a);
                Console.WriteLine(b);
                int c;
                for (int i = 1;i<= 5; i++)
                {
                    c = a + b;
                    Console.WriteLine(c);
                    a = b;
                    b = c;

                }

            }
        }*/
    

}
