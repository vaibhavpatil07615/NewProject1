using NewProject1.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NewProject1.Array
{
    /*  class Checknumber
      {
          static void Main(string[] args)
          {
              int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //  int indx = Arr.IndexOf<int>(arr,4);
              int val = arr[indx];

          */














    // Console.WriteLine("no is not present");
    /* for (int i = 0;i < arr.Length; i++)
      {
          if (num  != arr[i])
          {
              Console.WriteLine("number is not present in array.");
          }
      }*/
















    class ArrayAverage
    {
        // c. find out average of array element using interger average method and double average method
        public static int Average(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }
            int average = sum / arr.Length;
            return average;

        }
        public static double Average2(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }
            double average = sum / arr.Length;
            return average;



        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine(" enter " + (arr.Length) + "element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }


            ArrayAverage.Average(arr);
            Console.WriteLine("average using integer method = " + Average(arr));
            ArrayAverage.Average2(arr);
            Console.WriteLine("average using double type method = " + Average2(arr));


        }
    }

    class NegativeNumber
    { // c. print total negative number from array and count it.
        static void Main(string[] args)
        {
            int[] a = { 1, -2, -3, 5, -6, -7 };
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {


                    count++;
                    Console.WriteLine(a[i]);


                }



            }

            Console.WriteLine("total negative numbers in array = " + count);

        }

    }
    class FrequencyDigit
    {
        // c. check frequency of each digit 
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
    class MaximumDigit
    { //c. printmaximum and minimum digit from array.
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
            MaximumDigit m = new MaximumDigit();
            m.display(arr);



        }
    }
    class EvenOdd
    {
        // c. put even and odd number in 2 seprate array b,and c array.
        static void Main(string[] args)
        {
            int[] a = new int[7];
            int[] b = new int[7];
            int[] c = new int[7];
            for (int i = 1; i < a.Length; i++)
            {

                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("even numbers array : ");


            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[i] = a[i];
                    Console.WriteLine(b[i]);


                }

            }
            Console.WriteLine("odd numbers array:");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                {
                    c[i] = a[i];

                    Console.WriteLine(c[i] + "\t");
                }
            }
        }
    }
    class Smallest
    {
        // c. find second smallest element from array
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }





            }
            Console.WriteLine("second smallest number from array = " + arr[1]);


        }
    }

    class Merge
    {
        // I merge 2 arrays to 3rd array without repeated element.
        static void Main(string[] args)
        {
            int[] a = { 3, 2, 3, 5, 6, 7, 7 };

            int[] b = { 3, 8, 9, 10, 11, 12, 14, };
            Console.WriteLine("1st array:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("2nd array :");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();

            var c = a.Union(b).ToArray();
            Console.WriteLine("new array:");
            foreach (int i in c)
            {
                Console.Write(i + " ");
            }











            //  int[] c = new int[a.Length + b.Length];
            //int p = 0;
            /* for (int i = 0; i < a.Length; i++)
             {
                 c[p] = a[i];
                 p++;
             }
             for (int i = 0; i < b.Length; i++)
             {

                 bool ispresent = false;
                 for (int k = p - 1; k >= 0; k--)
                 {
                     if (b[i] == c[k])
                     {
                         ispresent = true;
                         break;
                     }


                 }
                 if (ispresent == false)
                 {
                     c[p] = b[i];
                     p++;
                 }
                 for ( i = 0; i < p; i++)
                 {
                     Console.WriteLine(c[p]);
                 }
             }*/




















            //Console.WriteLine(c[j]);

        }







    }
    class Merge2
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 7 };
            int[] arr2 = { 1, 8, 9, 10, 6, 11 };
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int k = 0;
            bool isduplicate;
            for (int i = 0; i < arr1.Length; i++)
            {
                isduplicate = false;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    { isduplicate = true; break; }


                }

                if (isduplicate == false)
                {
                    arr3[k++] = arr1[i];

                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                isduplicate = false;
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        isduplicate = true;
                        break;
                    }
                }
                if (!isduplicate)
                {
                    arr3[k++] = arr2[i];
                }
            }
            Console.Write("Merged array");
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                Console.Write(arr3[i] + " ");
            }

        }
    }


    class NegetiveReplace
    {
        //  c. negative replace with square of its immediate left.
        // if 1st digit is negative, it replace with last digit square
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine(" enter array " + (arr.Length) + " element ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

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
    }
    class Negativesort
    {
        // negative number appear before positive.
        static void Main(string[] args)
        {
            int[] a = { 5, -5, 6, -7, 8, 9, -9, 10, 11, -6 };
            int n = a.Length;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] <= 0)
                {
                    int temp = a[j];
                    a[j] = a[i];
                    a[i] = temp;
                    j++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
            }
        }



    }

   
}

        
    













        
    




    

