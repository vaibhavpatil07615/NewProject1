using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Array
{
    internal class Arrayadvance
    {
        // ascending order sorting of character array
        static void Main(string[] args)
        {
            char[] ch = new char[5];

            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] > ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }

                }
            }
            Console.WriteLine(ch);


        }

    }
    class Duplicate
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {


                int count = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {

                    for (int j = i + 1; j < arr.Length; j++)

                    {
                        if (arr[j] == arr[i])
                        {
                            count++;
                        }
                    }

                    if (count > 1)
                    {
                        sum += 1;

                    }


                }





            }
            Console.WriteLine("number of duplicate from array =" + sum);



        }
    }
    class Frequency
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {


                int count = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {

                    for (int j = i + 1; j < arr.Length; j++)

                    {
                        if (arr[j] == arr[i])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(arr[i] + " = " + count);



                }
            }
        }
    }
    class Replace
    {
        static void Main(string[] args)
        {
            char[] ch = { 'y', 'T', 'F', 'g', 'z' };
            for (int i = 0; i < ch.Length; i++)
            {

                      

                    

                if (ch[i] == 'z' || ch[i] == 'Z')
                {
                    Console.WriteLine('b');
                }
                if (ch[i] == 'y' || ch[i] == 'Y')
                {
                    Console.WriteLine('a');
                }
                else
                {
                    ch[i] = (char)(ch[i] + 2);
                }
               
                
                
                
               Console.WriteLine(ch[i]);
            }



        }
    }
    class Addarray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int[] b = { 8, 9, 10, 11, 12, 13, 14 };
            int[] c = new int[14];

            for (int i = 0; i < a.Length; i++)
            {

                c[i] = a[i];
                Console.WriteLine(string.Join(" ", c[i]));

            }
            for (int i = 0; i < b.Length; i++)
            {

                c[i] = b[i];
                Console.WriteLine(c[i]);

            }


        }

    }
    class Addition
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int[] a = { 1, 2, 3, 4, 5, 6, 7 };
                int[] b = { 8, 9, 10, 11, 12, 13, 14 };
                int[] c = new int[7];

                for (int i = 0; i < a.Length&& i< b.Length; i++)
                {

                    c[i] = a[i] + b[i];
                    Console.WriteLine(c[i]);

                }
               
            }
        }
    }
}




