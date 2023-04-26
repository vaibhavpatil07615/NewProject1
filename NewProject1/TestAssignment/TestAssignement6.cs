using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.TestAssignment
{
    // create password with maximum size of 10 in which:
    // 1 number , 1 special symbol, 1 capital lettter, and other samall 
    // if condition not satisfy create custom exception.
    internal class PasswordException : Exception
    {
        public PasswordException() {
            Console.WriteLine("enter at least 1 number");
        }
        public PasswordException(string password) : base(password) { }




    }
    class Password1
    {
        public void Checkstring(string chars)
        {
            char[] c = chars.ToCharArray();
            if (chars.Length <= 10)
            {
               

                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] >= '0' && c[i] <= '9')  
                    {

                        Console.WriteLine("password saved succesfully");
                    }
                    else
                        
                    throw new PasswordException("please  enter 1 number, 1 symbol in password");










                }



            }
            else throw new PasswordException("password must be 10 or less than 10");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter password to check");
            string s = Console.ReadLine();
            Password1 p = new Password1();
            try
            {
                p.Checkstring(s);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }

    // null pointer exception == null refrence exception
    class Nullpointer
    {
        static void Main(string[] args)
        {

            /* string v = null;
             if (v.Length == null)
             {
                 Console.WriteLine(v);
             }*/







        }


    }
    // addition of all number from string


    class AdditonNum
    {
        public static void Adddigit (string s)
        {
            char[]chars = s.ToCharArray();
            int sum = 0;
            for (int i =0; i<s.Length; i++)
            {
                if (s[i] >='0' && s[i] <= '9')
                {
                    sum = sum+ (s[i]- '0');

                }
               
            }
            Console.WriteLine("total sum of digit from string  = " + sum);


        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("please enter string");
            string s = Console.ReadLine();
            AdditonNum.Adddigit(s);

        }
    }
    class Commoncharacter
    {
        public void Common(string s,string s1)
        {
            string sortstring = " ";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    if (s[i] == s1[j])
                    {
                        sortstring = sortstring + s1[j];
                    }
                }
            }
          // char[] ch = sortstring.ToCharArray();
            for (int i = 0;i < sortstring.Length; i++)
            {
                for (int j = i+1; j < sortstring.Length; j++)
                {
                   
                        char  temp = sortstring[i];
                   // sortstring[i] = sortstring[j];  
                   //  sortstring[j] = temp;
                    
                    Console.WriteLine(sortstring[i]);

                }
            }
          








           // Console.WriteLine(sortstring);



        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st string");
            string s = Console.ReadLine() ;
            Console.WriteLine("enter 2nd string");
            string s1 = Console.ReadLine();

            Commoncharacter v = new Commoncharacter();
            v.Common(s, s1);



        }
    }

    class CharacterPattern
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine() ;
           for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(s[j]+" ");
                }
                Console.WriteLine();
            }
          //  for (int i = s.Length - 2; ; i >= 1; i--){

           // }
            
            
        }
    }
        
}


    

