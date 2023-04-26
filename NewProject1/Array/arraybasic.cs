using NewProject1.TestAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Array
{
    //array assignment 9 march 
    internal class arraybasic
    {
        static void display(char[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
            Console.WriteLine("......");

            foreach (char x in c)
            { Console.WriteLine(x); }
            Console.WriteLine("....");
            Console.WriteLine(string.Join(" ", c));
        }
        static void Main(string[] args)
        {
           

            char[] c = new char[4];
            Console.WriteLine("enter"+(c.Length) + "character");
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = char.Parse(Console.ReadLine());
            }
            arraybasic.display(c);

        }
    }

    class Sumarray
    {
        public static void Sum(int[] arr) {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)

            {
                sum += arr[i];


            }
            Console.WriteLine(sum);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter"+(arr.Length)+"array element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Sumarray.Sum(arr);
        }
    }

    class Odd
    {
        public static void display(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("enter element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            Odd.display(arr);

        }
    }
    class Maximum
    {
        public void display(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            Console.WriteLine("maximum digit from array =" + max);
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine("minimum digit from array =" + min);

        }




        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter array element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Maximum m = new Maximum();
            m.display(arr);



        }
    }
    class Prime
    {
        public static void display(int[]a){
            for (int i = 0; i < a.Length; i++)
            {
                bool isprime = true;
                for (int k = 2; k < a[i]; k++)
                {
                    if (a[i] % k == 0)
                    {
                        isprime = false;
                        break;
                    }
                }


                if (isprime == true)
                {
                    Console.WriteLine( a[i]);

                }
            }



        }
    



       static void Main(string[] args)
        { 

            int[] a = new int[10];
            Console.WriteLine("enter" + (a.Length) + "element of array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Prime.display(a);
         
        }
    }
    class Reverse
    {
        public static void  display(char[]c)
        {
            int j = c.Length - 1;
            for (int i = 0; i < c.Length / 2; i++)
            {
                char temp = c[i];
                c[i] = c[j];
                c[j] = temp;
                j--;

            }
            // Console.WriteLine(string.Join("",c));
            Console.WriteLine(c);

        }
        static void Main(string[] args)
        {
            char[] c  = new char[5];
            Console.WriteLine("enter " + (c.Length) + " character of array");
            for (int i =0;i< c.Length; i++)
            {
                c[i] = char.Parse(Console.ReadLine());

            }
            Reverse.display(c);


        }
    }
}


