using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Assignment
{
    internal class Loop
    {
        
            static void Main(string[] args)
            {


                Console.WriteLine("even number between 121 to 229");

                for (int i = 121; i <= 229; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }


                Console.WriteLine("odd number between 521 to 229");
                int odd = 521;
                while (odd >= 229)
                {
                    if (odd % 2 == 1)
                    {
                        Console.WriteLine(odd);
                    }
                    odd--;
                }


                Console.WriteLine("GCD of number");
                Console.WriteLine("enter number");
                int num = int.Parse(Console.ReadLine());
                int gcd = 1;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                }

                Console.WriteLine("print a to z alphabet");
                for (char i = 'a'; i <= 'z'; i++)
                {
                    Console.WriteLine(i);
                }









            }





        }



        class LOOP
        {
            static void Main(string[] args)
            {
                Console.WriteLine(" sum odd number between 1 to n");
                Console.WriteLine("enter number");
                int num2 = int.Parse(Console.ReadLine());
                int sum = 0;



                for (int i = 1; i <= num2; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum = sum + i;

                    }
                    Console.WriteLine(sum);





                }
                Console.ReadLine();
                Console.WriteLine("sum of even number from 1 to n");
                int n = int.Parse(Console.ReadLine());
                int sum2 = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum2 = sum2 + i;
                    }

                }
                Console.WriteLine(" sum of 1 to n even number is = " + sum2);
                Console.ReadLine();

                Console.WriteLine("count odd number between 20 to 50");
                int count = 0;
                for (int i = 20; i <= 50; i++)
                {
                    if (i % 2 == 1)
                    {
                        count++;
                    }

                }


               












            }






        }
        class WileLoop
        {
            static void Main(string[] args)
            {
                Console.WriteLine("count number of digit from input number");
                int num = int.Parse(Console.ReadLine());
                int digit = 0;
                while (num > 0)
                {
                    num = (num / 10);
                    digit++;


                }
                Console.WriteLine(digit);
                Console.ReadLine();


                Console.WriteLine("product of digit");
                int n1 = int.Parse(Console.ReadLine());
                int product = 1;
                int digit2 = 0;
                while (n1 > 0)
                {
                    digit2 = n1 % 10;
                    product = product * digit2;
                    n1 = n1 / 10;
                }
                Console.WriteLine(product);

                Console.WriteLine("table of given input");
                Console.WriteLine("please enter table number");
                int table = int.Parse(Console.ReadLine());
                int t = 1;
                int ans;
                while (t <= 10)
                {
                    ans = table * t;
                    t++;

                    Console.WriteLine(table + " * " + t + " = " + ans);
                }
                Console.ReadLine();

            Console.WriteLine(" accept base and exponent and find power ");

            Console.WriteLine("enter base");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter exponent");
            int expo = int.Parse(Console.ReadLine());

            int power = 1; 
            int i = 1;
            while (i<= expo)
            {
                power = power * base1;
                i++;

            }
            Console.WriteLine(power);













        }

        }
        class Frequencydigit
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter number");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("enter digit whose frequency check in number");
                int d = int.Parse(Console.ReadLine());
                int count = 0;
                while (n > 0)
                {
                    if (n % 10 == d)
                    {
                        count++;

                    }

                }
                Console.WriteLine("frequency of digit = " + count);
                Console.ReadLine(); 

               Console.WriteLine("check number is palindrome or not");
                Console.WriteLine("enter number to check");
                int n1 = int.Parse(Console.ReadLine());
                int revnum = 0;
                int temp = n1;
                while (n1 > 0)
                {
                    int rev = n1 % 10;

                    revnum = (revnum * 10) + rev;
                    n1 = n1 / 10;

                }
                if (revnum == temp)
                {
                    Console.WriteLine("the number is palindrome");
                }
                else Console.WriteLine("the number is not palindrome");
                Console.ReadLine();




            }


        }
     class Krushnamurthy
    {
        static void Main(string[] args)
        {
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
                else Console.WriteLine("not kruhnamuthy number");


            
            

        }
    }
    class Harshadniven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("check number is harshad niven number or not");
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;

            }
            if (num % sum == 0)
            {
                Console.WriteLine("harshad niven number");
            }
            else Console.WriteLine("not harshad niven number");
        }
    }



    }


