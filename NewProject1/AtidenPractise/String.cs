using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.AtidenPractise
{
    internal class String
    {
        public static void Merge (string s1, string s2)
        {
            string result = "";
            for (int i = 0;i<s1.Length|| i < s2.Length; i++)
            {
                if (i < s1.Length)
                {
                    result += s1[i];

                }
                if (i < s2.Length)
                {
                    result += s2[i];
                }
            }
            Console.WriteLine("output string = " + result);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(" enter 1st string ");
            string s = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string s2 = Console.ReadLine();
            String.Merge(s, s2);

        }


    }
}
