using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NewProject1.Array
{
    internal class twoDarray
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Console.WriteLine("enter array element");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j =0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("......");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j =0;j< a.GetLength(1); j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine(" ");
            }

        }
        
        
    }
    class mat
    {
        int i, j, m, n;
        int[,] a = new int[20, 20];
        int[,] c = new int[20, 20];
        public void getmatrix()
        {
            Console.WriteLine("Enter the Number of Rows : ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number of Columns : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Given Matrix");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void col()
        {
            int c;
            for (i = 1; i <= n; i++)
            {
                c = 0;
                for (j = 1; j <= m; j++)
                {
                    c = c + a[j, i];
                }
                Console.WriteLine("{0} Column Sum : {1}", i, c);
            }
        }
    }
    class matsum
    {
        static void Main(string[] args)
        {
            mat ma = new mat();
            ma.getmatrix();
            ma.col();
            Console.ReadLine();
        }
    }
    class MaximumRow
    {
     

        public static void Maxelement(int no_of_rows, int[][] arr)
        {
            int i = 0;
            int max = 0;
            int[] result = new int[no_of_rows];
            while(i < no_of_rows)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }

                }
                result[i] = max;
                max = 0;
                i++;
            }
            printArray(result);

        }
        // print array element
        private static void printArray(int[] result) {
           for (int i =0;i< result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }



        
        }
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
           {
                new int []{3,5,7,8},
                new int []{10,23,25,67},
                new int []{89,90,91,92},
                new int []{98,99,90,123}
           };
            Maxelement(4, arr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.AddTwoDArray();
            Console.ReadLine();
        }

        void AddTwoDArray()
        {
            Console.Write("Enter Number to Define Rows & Column:- ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[arrayLength, arrayLength];
            int[,] arraySecond = new int[arrayLength, arrayLength];
            int[,] arraySum = new int[arrayLength, arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("Array Index [{0}][{1}]:- ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("This is Your First Array:-");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(array[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + array[i, j]);
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Now Enter Your Second Array");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("Array Index [{0}][{1}]:- ", i, j);
                    arraySecond[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("This is Your Second Array:-");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(arraySecond[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + arraySecond[i, j]);
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Do you want to add this arrays:- (Y/N)");

            string userInput = Convert.ToString(Console.ReadLine());

            if (userInput.ToUpper() == "Y")
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    for (int j = 0; j < arrayLength; j++)
                    {
                        arraySum[i, j] = array[i, j] + arraySecond[i, j];
                    }
                }
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Array is Added Successfully Here is your Result");
                Console.WriteLine("---------------------------------------------------------------------");
                for (int i = 0; i < arrayLength; i++)
                {
                    for (int j = 0; j < arrayLength; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write(arraySum[i, j]);
                        }
                        else
                        {
                            Console.Write(" " + arraySum[i, j]);
                        }

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Program Terminate Press Enter To Exit............");
            }
        }
    }
    class Pattern4
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            Console.WriteLine("enter array element");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j =0;j<arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(".......");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j==0 || j == arr.GetLength(1) - 1 || i == j)
                    {
                        Console.Write(arr[i,j]);
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}

