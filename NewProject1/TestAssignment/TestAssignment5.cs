using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.TestAssignment
{
    internal class TestAssignment5
    {
        public static void Wordoccurance(string str)
        {
            string[] s = str.Split();
            for (int i = 0; i < s.Length; i++)
            {
                bool ispresent = false;
                int count = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (s[j] == s[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    for (int k = i + 1; k < s.Length; k++)
                    {
                        if (s[k] == s[i])
                        {
                            count++;
                        }
                    }
                    Console.Write(s[i] + " " + count);
                }
                Console.WriteLine();
            }
        }
        public static void CheckAnagram(string str1, string str2)
        {
            string s1 = str1.ToLower();
            string s2 = str2.ToLower();
            char[] c = s1.ToCharArray();
            char[] c1 = s2.ToCharArray();
            if (c.Length == c1.Length)
            {



                for (int i = 0; i < c.Length; i++) // sort 1st array in ascending order.
                {
                    for (int j = i+1; j < c.Length; j++)
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
                    for (int j = i+1; j < c1.Length; j++)
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

            static void Main(string[] args)
            {
                Console.WriteLine("enter string to count number of occurance of word.");
                string t = Console.ReadLine();
                TestAssignment5.Wordoccurance(t);
                Console.WriteLine("enter 1st string ");
                string u = Console.ReadLine();
                Console.WriteLine("enter 2nd string ");
                string u1 = Console.ReadLine();
                TestAssignment5.CheckAnagram(u, u1);


            }
        
    }
    class Countword
    { // count total number of words from string.

        public static void Count(string s)
        {
            int total = 0;
            string[] n = s.Split();

            total = n.Length;

            Console.WriteLine(" total words in given string = " + total);
        }


        public static void Uppercase(string v)
        {
            string op = " ";
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] >= 'a' && v[i] <= 'z')
                {
                    op = op + (char) (v[i] - 32);
                }
                
            }
            Console.WriteLine(op );


        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            Countword.Count(s);

            Console.WriteLine("enter string to convert it uppercase");
            string u = Console.ReadLine();
            Countword.Uppercase(u);



        }
    }
    class SortArray
    {
        // sort 10 names from array in decending order.
        public static void Sort(string c)
        {
            string[] f = c.Split();

            for (int i = 0;i< f.Length;i++)
            {
               for (int j = i+1; j < f.Length; j++)
                {
                    

                  
                }
            }



        }
        // count total alphabet, character ,numbers from string.
        public static void Count (string c)
        {
            char[] s = c.ToCharArray();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for (int i = 0;i< s.Length;i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z' || s[i] >='A' && s[i] <='Z')
                {
                    count1++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                   // count2 = count2 + (int)(char.GetNumericValue(s[i]));
                   count2++;
                }
                
                else  
                    count3++;
            }
            Console.WriteLine("aplphabet = " + count1);
            Console.WriteLine(" numbers = " + count2);
            Console.WriteLine( " characters = " + count3);

        }
        // minimum character from  string.
        public static void Minchar(string c)
        {
            char[] s = c.ToCharArray();
            for (int i = 0; i < s.Length ; i++)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                    if (s[i]> s[j])
                    {
                        char temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
                if (i == 0)
                {
                    Console.WriteLine( "smallest element from string = " + s[i]);

                }
                
            }
        }



        static void Main(string[] args)
        {
            /* Console.WriteLine("enter 10 names in array");
             string[] s = new string[9];
             for (int i = 0;i< s.Length;i++)
             {
                 s[i] = Console.ReadLine();

             }
             SortArray.Sort(s);


 */
            Console.WriteLine("enter string to check ");
            string c = Console.ReadLine();
            SortArray.Count(c);
            Console.WriteLine("enter string");
            string v = Console.ReadLine();  
            SortArray.Minchar(v);

        }
    }
    class Replace
    {
        // replace 0 with 1.
        public static void Replace0(int[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 0)
                {
                    c[i] = 1;
                }
                Console.WriteLine(c[i]);
            }

        }
        // replace negative number its immediate left element.
        public static void Replace1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] < 0)
                {
                    arr[0] = arr[arr.Length - 1] * arr[arr.Length - 1];
                }


                if (arr[i] < 0 && arr[i - 1] > 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
                else if (arr[i] < 0 && arr[i - 1] < 0)
                {
                    arr[i] = arr[i] * arr[i];
                }
                if (arr[i] == 0)
                {
                    arr[i] = arr[i];
                }
                Console.WriteLine(arr[i]);


            }


        }

        static void Main(string[] args)
        {
            int[] arr1 = new int[7];
            Console.WriteLine("enter element");
            for (int i = 0; i<arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Replace.Replace0(arr1);


            int[] arr2 = new int[7];
            Console.WriteLine("enter element");
            for (int i = 0;i<arr2.Length;i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());  
            
            }
            Replace.Replace1(arr2);






        }
    }

}
