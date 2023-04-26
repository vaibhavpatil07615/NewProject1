using NewProject1.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NewProject1.AtidenPractise
{
    internal class Programme
    {
        public void Vowel(string v)
        {
            char[] arr = v.ToCharArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                {
                    count++;

                }
            }
            Console.WriteLine("number of vowel in name = " + count);

        }


        static void Main(string[] args)
        {
            /* Console.WriteLine("enter string to check palindrome.");
             string s = Console.ReadLine();
             string reverse = "";
             for (int i = s.Length - 1;i>= 0; i--)
             {
                 reverse = reverse + s[i];
             }
             //string temp = s;
             Console.WriteLine(reverse);
             if (s == reverse)
             {
                 Console.WriteLine("palindrome string");
             }
             else Console.WriteLine("not palindrome");*/
            Console.WriteLine("enter string to count vowel");
            string c = Console.ReadLine();
            Programme p = new Programme();
            p.Vowel(c);

        }







    }
    //find second largest from array.
    class Secondlargest
    {
        public static void Second(int[] arr)
        {
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
            Console.WriteLine(arr[1]);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("enter" + (arr.Length) + "element in array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Secondlargest.Second(arr);



        }




    }
    // remove duplicate character from character type array.
    class Duplicate
    {
        public static void Character(char[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {

                int count = 1;
                bool ispresent = false;
                for (int j = i - 1; j >= 0; j--)
                {

                    if (c[i] == c[j])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    for (int k = i + 1; k < c.Length; k++)
                    {
                        if (c[i] == c[k])
                        {
                            count = count + 1;
                        }
                    }
                    // Console.WriteLine(c[i] + " " + count);

                    if (count == 1)
                    {
                        Console.WriteLine(c[i] + "\n");
                    }
                }


            }

        }
        public static void Number(string n)
        {
            char[] c = n.ToCharArray();
            int sum = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] >= '0' && c[i] <= '9')
                {
                    sum += (int)(char.GetNumericValue(c[i]));
                }
            }
            Console.WriteLine("sum of all digit from string = " + sum);
        }





        static void Main(string[] args)
        {
            char[] ch = new char[6];
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = char.Parse(Console.ReadLine());
            }


            Duplicate.Character(ch);
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            Duplicate.Number(s);

        }
    }
    class Convert
    {
        public void Vowel(string c)
        {
            //char[] ch = c.ToCharArray();
            string op = "";
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 'a' || c[i] == 'e' || c[i] == 'o' || c[i] == 'i' || c[i] == 'u')
                {
                    op = op + (char)(c[i] - 32); // lowercase to uppercase


                }
                else op = op + c[i];
            }
            Console.WriteLine("output = " + op);


        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string c = Console.ReadLine();
            Convert cv = new Convert();
            cv.Vowel(c);

        }
    }
    class Merge
    {
        public static void Mergestrng(string s1, string s2)
        {
            string output = "";
            for (int i = 0; i < s1.Length; i++)
            {




            }


            Console.WriteLine("merge string = " + output);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st string");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string s2 = Console.ReadLine();
            Merge.Mergestrng(s1, s2);

        }
    }
    class twodarray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length of rows and column");
            int arraylength = int.Parse(Console.ReadLine());
            int[,] array = new int[arraylength, arraylength];
            int[,] arraysecond = new int[arraylength, arraylength];
            int[,] sum = new int[arraylength, arraylength];
            Console.WriteLine("enter array element");
            for (int i = 0; i < arraylength; i++)
            {
                for (int j = 0; j < arraylength; i++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());

                }
            }

            for (int i = 0; i < arraylength; i++)
            {
                for (int j = 0; j < arraylength; i++)
                {
                    arraysecond[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < arraylength; i++)
            {
                for (int j = 0; j < arraylength; i++)
                {
                    Console.Write(array[i, j] + " ");

                }
                Console.WriteLine();
            }
            for (int i = 0; i < arraylength; i++)
            {
                for (int j = 0; j < arraylength; i++)
                {
                    Console.Write(arraysecond[i, j] + " ");

                }
                Console.WriteLine();
            }



            for (int i = 0; i < arraylength; i++)
            {
                for (int j = 0; j < arraylength; i++)
                {
                    sum[i, j] = array[i, j] + arraysecond[i, j];
                }
            }
            for (int i = 0; i < arraylength; i++)
            {
                for (int j = 0; j < arraylength; i++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class Negativesort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < 0)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    j++;
                }

            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }




        }



    }
    abstract class  Mobile
    {
       public abstract void OperatingSystem();

        public abstract void Cost();
           

    }

    class Mi : Mobile
    {
      
        public override void Cost()
        {
            
            Console.WriteLine("cost of mi not 9 mobile " + 15000 + "rs");
        }
        public override void OperatingSystem()
        {
            Console.WriteLine("operating system of mi note 9 " + "android/media tek helio");
        }

    }
    class Apple : Mobile
    {
        public override void Cost()
        {

            Console.WriteLine("cost of iphone 14 pro max " + 189000 + "rs");
        }
        public override void OperatingSystem()
        {
            Console.WriteLine("operating system of iphone 14 pro max " + " = ios");
        }
    }

        class Output
        {
            static void Main(string[] args)
            {
                Console.WriteLine("mi note 9 is mobile of mi company their detail are");
                Mobile m = new Mi();
                m.Cost();
                m.OperatingSystem();

                Console.WriteLine("iphone is mobile of apple company. their detail are:");

                Mobile c = new Apple();
                c.Cost();
                c.OperatingSystem();


                

            }
           
            
        }

    class Missing
    {
        public static void     Miss(int[] arr,int N)
        {
            int sum = 0;
            int totalsum = N * (N + 1) / 2;
            for (int i = 0; i< arr.Length; i++)
            {
                sum += arr[i];
            }
            int Missingnumber = totalsum - sum;

            Console.WriteLine( "missing element from array = " + Missingnumber);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the maximum value for integer N");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N - 1];
            Console.WriteLine("enter element of array from 0 to " + N + " integer range ");
            for (int i = 0;i< arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Missing.Miss(arr, N);
              




        }
    }
    

   
    
}
    

   





