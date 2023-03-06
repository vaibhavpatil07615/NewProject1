using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NewProject1.TestAssignment
{
    internal class Range

    {
        static void Main(string[] args)

        {
            for (int i = 1; i <= 100; i++)
            {
                bool isnum = true;
                if (i % 5 == 0)
                {
                    isnum = false;

                }
                if (isnum == true)
                {
                    Console.WriteLine(i);
                }
            }


            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);

            Console.WriteLine("check number is spy or not");
            Console.WriteLine("enter number to be check");
            int n = int.Parse(Console.ReadLine());
            int mul = 1;
            int sum = 0;
            int temp = n;
            while (n > 0)
            {
                int digit = n % 10;
                sum = sum + digit;
                mul = mul * digit;
                n = n / 10;

            }


            if (sum == mul)
            {
                Console.WriteLine("spy number");
            }
            else

                Console.WriteLine("not spy number");


            Console.WriteLine("check number is trimorphic or not");
            int n2 = int.Parse(Console.ReadLine());
            int cube = n2 * n2 * n2;

            int digit2 = cube % 10;
            if (digit2 == n2)
            {
                Console.WriteLine("trimorphic number");
            }
            else
                Console.WriteLine("not trimorphic number");

        }
    }
    class Pyramid1

    {

        static void Main(string[] args)
        {


            for (int i = 1; i <= 4; i++)// forward pyramid
            {
                for (int j = i; j <= 3; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write(i);
                }

                Console.WriteLine(" ");
            }
        }
    }
    class Pyramid2
    {

        static void Main(string[] args)
        {


            int j;
            for (int i = 1; i <= 5; i++)
            {
                for (j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 2 * i - 1; k <= 7; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 10;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }


    class Series

    {
        static void Main(string[] args)
        {


            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());




            int a = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 == 1)
                {
                    a = -i * -i;

                    Console.WriteLine(-a);




                }


            }
        }
    }

    class fibonacci
    {

        static void Main(string[] args)
        {


            Console.WriteLine("fibbonacci series");
            int a = 0;
            int b = 1;
            int c =0;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i <= 17; i++)
            {
                c = a + b;
                a = b; // swapping of a and b
                b = c; // swapping of b amd c



                Console.WriteLine(c);
            
                Console.WriteLine("sum of factorial of numbers between 1 to 20");
                int fact = 1;
                int sum = 0;
                for (int i1 = 1; i1 <= 5; i1++)
                {

                    fact = fact * i1;
                    sum = sum + fact;


                }
                Console.WriteLine(sum);






            }
            int i2 = 1; // 13Q.
            while (i2 <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i2);
            }
        }
    }




    class Coprime

    {

        static void Main(string[] args)
        {



            int ans = 0;
            for (int i = 1; i <= 10; i++)
            {
                ans = i * i + i * i * i;

                Console.WriteLine(ans);
            }

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int diff = 0;

            // bool isprime1 = true;

           bool isprime1 = true;
            bool isprime2 = true;
            for (int i = 2; i < n1; i++)


            {
                if (i % n1 == 0)
                {
                    isprime1 = false;
                    break;

                }
                
            }


               
            for (int j = 2; j < n2; j++)
            {
                if (n2 % j == 0)
                {
                    isprime2 = false;
                    break;
                }
                
            }



            if (isprime1 == true && isprime2 == true)
            {
                diff = n2 - n1;
            }
             if (diff == 2)
            {
                Console.WriteLine("coprime");
            }

            else
            {
                Console.WriteLine("not co prime");
            }

            
                    
                
            
            









        }
    }
}





    


