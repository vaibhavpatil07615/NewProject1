using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NewProject1.NewFolder
{
    internal class nested
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int num = 1; num <= 10; num++)
            {
                bool isprime = true;
                for(int i = 2; i < num; i++)
                {
                    if(num%i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime == true)
                {
                    sum = sum + num;
                }
            }
            Console.WriteLine("addition of prime number = " + sum);
          
               
              

            
        }
          
    }
    class Tables
    {
        static void Main(string[] args)
        {
            int ans = 0;
            Console.WriteLine( "tables between 1 to 5");
            for (int table = 1; table <6 ; table++)
            {
                for(int i = 1; i < 11; i++)
                {
                    ans = table * i;
                    Console.WriteLine(  table + " * " + i + " = " + ans);
                }
                
            }
           
        }
    }
    class Factorial
    {
        static void Main(string[] args)
        {
            int sum = 0;
              int   fact = 1;
            for(int num = 1; num <= 5; num++)
            {
               
                    fact = fact * num;
                    sum = sum + fact;
                    

                
                

              
            }
            Console.WriteLine(sum);


        }
    }
}
