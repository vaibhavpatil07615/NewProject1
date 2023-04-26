using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NewProject1
{
    internal class Mock
    {
        public static void Sum (int num){
            int sum = 0;
           
            int lastdigit = num % 10;
            while(num>= 10)
            {
                num = num / 10;
            }
            int firstdigit = num;
            sum = firstdigit + lastdigit;


            Console.WriteLine("sum of first and last digit = " + sum);









        }



        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            Mock.Sum(n);


        }

    }
  
        
       sealed class FlyingBird
        {
            string types;
           static  int Quantity;

        }

      //  class Example : FlyingBird
       

    class Printer
    {
        public virtual void show()
        {
            Console.WriteLine("display  dimesnsion of printer");
        }
    }
    class Laser : Printer
    {
        public sealed override void show()
        {
            Console.WriteLine("6*6");
        }
    }

    class Sum
    {
        public void Digit(int n)
        {
            int rev = 0;
            while (n > 0)
            {
                int digit = n % 10;
                
                rev = rev * 10 + digit;
                //int total = rev;
                n = n / 10;
               
            }
           


        }
       // sum of even digit from number
       public void Even(int e)
        {
            int count = 0;
            int sum = 0;
            while (e > 0)
            {
                int digit = e % 10;
                count++;


                if (count % 2 == 0)
                {
                    sum += digit;

                }
                e /= 10;
                
            }
            Console.WriteLine(sum);
        }


        static void Main(string[] args)
        {
            Sum c = new Sum();
            // c.Digit(1234);
            c.Even(789456);


        }
    }
    class Patterns
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+ " ");
                }
                Console.WriteLine();
            }
        }

    }

    
}
