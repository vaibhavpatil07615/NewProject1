using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.String
{
    internal class Assignment
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter string to reverse");
            string s = Console.ReadLine();
            string[] st = s.Split();
            string reverseword = "";
            for (int i =0;i< st.Length; i++)
            {
                string word = st[i];
                string myrevers = "";
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    myrevers += word[j];
                }
                reverseword = reverseword + " " + myrevers;
            }
            Console.WriteLine(reverseword);
           

        }
    }
    class Secondlargest
    {
        static void Main(string[] args)
        {
           
            
                int[] arr = new int[6];
                Console.WriteLine("enter" + (arr.Length) + "element to check" );
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i <= arr.Length; i++)
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;

                        }
                    }





                }
                Console.WriteLine("second largest number from array = " + arr[1]);


            
        }
    }
    class Identicalarray
    {
        static void Main(string[] args)
        {
            int[]a = new int[6];
            int[]b = new int[4];
            Console.WriteLine("enter element of array 1");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" enter element for array 2");
            for (int i =0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            bool isidentical = false;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {



                    if (a.Length == b.Length && a[i] == b[j])
                    {
                        isidentical = true;
                        break;

                    }
                    else isidentical = false;

                }
            }
            if (isidentical == true)
            {
                Console.WriteLine("identical");
            }
            else
            {
                Console.WriteLine("not identical");
            }
        }
    }
    class Singledigit
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 1, 2, 3,2,8,9,7 };
            int n = arr.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
               
                while (sum < 10) {

                    sum += arr[i];

                }
               /* if (sum > 9)
                    break;*/
               
            }
            Console.WriteLine(sum);






        }
    }
}
