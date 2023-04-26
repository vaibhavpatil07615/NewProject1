using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.TestAssignment
{
    internal class Testassignment2
    {
        static void Main(string[] args)
        {
             for (int i = 1; i <= 100; i++)
             {
                 if (i % 5 == 0)
                 {
                     Console.WriteLine("");
                 }
                 else { Console.WriteLine(i); }

             }

            Console.WriteLine("factors of given number");
             Console.WriteLine("enter number");
             int num = int.Parse(Console.ReadLine());
             for (int i = 1; i <= num; i++)
             {
                 if (num % i == 0)
                 {
                     Console.WriteLine(i);
                 }
             }

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * i);
                }
            }
            Console.WriteLine("fibbonacci series");
            int a = 0;
            int b = 1;
            int c = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i <= 17; i++)
            {
                c = a + b;
                a = b; // swapping of a and b
                b = c; // swapping of b amd c
                Console.WriteLine(c);
            }
            //Console.WriteLine(c);



            Console.WriteLine("harshad number");
            Console.WriteLine("enter number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (num2 > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num2 = num2 / 10;

            }
            if (num2 % sum == 0)
            {
                Console.WriteLine("harshad niven number");
            }
            else Console.WriteLine("not harshad niven number");



        }

    }
    class Factors

    {
        static void Main(string[] args)
        {
            for (int i=1; i <= 100; i++)
            {
                if (i%3==0 && i % 5 == 0)
                {
                    Console.WriteLine("Red blue");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("blue");
                } 
                else Console.WriteLine(i);
            }

            Console.WriteLine("check number is krushnamurthy or not");
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            int fact;

            while (num > 0)
            {
                int digit = num % 10;
                fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;


                }
                sum = sum + fact;
                num = num / 10;
            }
            num = temp;
            if (num == sum)
            {
                Console.WriteLine("krushnamurthy number");

            }
            else Console.WriteLine("not krushnamurthy number");

        }

    }
}
