using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.String
{
    internal class Countchar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            int total = 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 0)
                {
                    count++;

                }
                //total += count;


            }
            Console.WriteLine("total character in given string = " + count);
        }
    }
    class Countword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            int total = 0;
            string[] n = s.Split();
           
            total = n.Length;
            
            Console.WriteLine(" total words in given string = " + total);

        }
    }
    class Reverseword
    {
        // reverse word of strimg except first and last word
        static void Main(string[] args)
        {
            






            Console.WriteLine("enter string to reverse");
            string s = Console.ReadLine();
            string[] st = s.Split();
            string reverseword = "";
            for (int i = 1; i < st.Length-1; i++)
            {
                string word = st[i];
                string myrevers = "";
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    myrevers += word[j];
                }
                reverseword = reverseword + " " + myrevers;
            }

          for (int j = 0; j < st.Length; j++)
            {
                if (j == st.Length-1)
                {
                    reverseword = reverseword + " "  + st[j];
                }
            }
            Console.WriteLine(st[0] + reverseword );


        }







    }
        
    
    class StringPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter string");
            string s = Console.ReadLine();
            string[] st = s.Split();
            for (int i = 0; i < st.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(st[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("check string is palindrome");
            string s = Console.ReadLine();
            string reverse = "";
            for (int i = 0; i < s.Length; i++)
            {
                reverse = s[i] + reverse;
            }
            Console.WriteLine("reverse string = " + reverse);
            if (reverse.Equals(s))
            {
                Console.WriteLine("the string is palindrome");
            }
            else Console.WriteLine("the string is not palindrome");
        }
    }
   
           
            

















        
    
    class Functions
    {
        static void Main(string[] args)
        {
            string s = "vaibhav  ";
            string g = "patil  ";
            string v = s.Trim();
             Console.WriteLine(v);
             //string[] t = s.Split();
             char[] c = s.ToCharArray();
             Console.WriteLine(c);
             string a = s.Substring(3);
             Console.WriteLine(a);
             string b = s.ToUpper();
             Console.WriteLine(b);
             string d  = s.ToLower();
             Console.WriteLine(d);
            Console.WriteLine(Object.ReferenceEquals(s, g)); // we get string comparison output in bool format(true/false)
          
            



        }
    }
    // 23 march task.
    class Name
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string b = Console.ReadLine();
            string[] st = b.Split();
            string word = "";

           
            for (int i = 0;i<st.Length-1;i++)
            {

                string c = st[i].Substring(0, 1);
                

                word = word + c + ".";
              




            }
           string last = " ";
            for (int j  = 0; j < st.Length; j++)
            {
                if (j == st.Length-1)
                {
                  last = st[j];
                }
            }
            Console.WriteLine(word + " " + last);
           

        }
    }
    class Addition
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("enter string");
            string s = Console.ReadLine();
            int sum1 = 0;
            


            char[] t = s.ToCharArray();
            for (int i = 0;i<t.Length;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    sum1 += t[j];


                   // sum1 = sum1 + t[i];
                   
                  
                }
               


            }
            Console.WriteLine(sum1);*/

            /* for (int i = 0; i < 10; i++)
               {
                   sum1 += i;
               }
               Console.WriteLine(sum1);*/




            /* for (int i = 0; i < 3; i++)
             {
                 if (t[i] <= 3)
                 {
                     if (char.IsDigit(t[i]))
                     {
                         sum1 = sum1 + t[i];

                     }




                 }*/
            Console.WriteLine("enter string ");
            string v = Console.ReadLine();
            int sum2 = 0;
            char[] c = v.ToCharArray();
            if (v.Length >= 3) { 
            


                for (int i = 0; i < 2; i++)
                {
                    if (char.IsDigit(c[i]))
                    {
                        sum2 += c[i];




                    }

                }
                Console.WriteLine(sum2);
            }
            else Console.WriteLine("invalid string");
           


           
        }









    }
    
    class Characterfrequency
    {
        // count number of character from string.
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
          //  int count = 1;
            for (int i = 0; i < c.Length; i++)
            {
                
               int count = 1;
                bool ispresent = false;
                for (int j = i-1; j >= 0; j--)
                {
                 
                    if (c[i] == c[j])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    for (int k  = i+1 ; k < c.Length; k++)
                    {
                        if (c[i] == c[k])
                        {
                            count = count+1 ;
                        }
                    }
                    Console.WriteLine(c[i] + " " + count);

                }
                
            }
            
        }
    }
    class Digitsum
    {
        // sum of each digit from string.
        static void Main(string[] args)
        {
             Console.WriteLine("enter string ");
             string s = Console.ReadLine() ;
             int sum = 0;
             for (int i = 0; i < s.Length; i++)
             {
                 if (char.IsDigit(s[i]))
                 {
                     sum = sum + (int)(char.GetNumericValue(s[i]));

                 }

             }
             Console.WriteLine("addition of all digit from string = " + sum);

        }
    }
    //24 march task 
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string str2 = Console.ReadLine();

            
                string s1 = str1.ToLower();
                string s2 = str2.ToLower();
                char[] c = s1.ToCharArray();
                char[] c1 = s2.ToCharArray();
                if (c.Length == c1.Length)
                {



                    for (int i = 0; i < c.Length; i++) // sort 1st array in ascending order.
                    {
                        for (int j = i + 1; j < c.Length; j++)
                        {
                            if ((c[i] < c[j]))
                            {
                                char temp = c[i];
                                c[i] = c[j];
                                c[j] = temp;

                            }

                        }



                    }
                    for (int i = 0; i < c1.Length; i++) // sort 2nd character array 
                    {
                        for (int j = i + 1; j < c1.Length; j++)
                        {
                            if (c1[i] < c1[j])
                            {
                                char temp = c1[i];
                                c1[i] = c1[j];
                                c1[j] = temp;
                            }

                        }

                    }
                    string t = new string(c);
                    string t1 = new string(c1);
                    if (t == t1)
                    {
                        Console.WriteLine("both string are anagram");
                    }
                    else Console.WriteLine(" not anagram");

                }
                else Console.WriteLine("length of both string are not equal");
            }



        }
    class Replacestring
    {
        //complete.
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();
            for (int i = 0; i < c1.Length; ++i)
            {
               


                for (int j = 0; j < c2.Length; j++)
                {
                    if (c1[i] == c2[j])
                    {
                        c1[i] = ' ';
                    }

                }
               
                Console.Write(c1[i] + " ");
            }
            
            //Console.WriteLine(c2);


        }

    }



}


