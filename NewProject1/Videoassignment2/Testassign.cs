using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NewProject1.Videoassignment2
{
    internal class Testassign
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine(" enter " +(arr.Length) + " element");
            for (int i =0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length;i++)
            {
                if (arr[i]%5 == 0)
                {
                    arr[i] = 0;
                }

                Console.WriteLine(arr[i]);
            }
            
        }
        
        
    }
    class Matrix
    {
        static void Main(string[] args)
        {
            int row = 3;
            int col = 3;
            int[,] matrix = new int[row, col];
            Console.WriteLine(" enter the element of matrix");
            for ( int i = 0; i< row; i++)
            {
                for (int j =0; j< col; j++)
                {
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine( );

                for (int j =0;j< col; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(matrix[i, j] + "\t ");
                    }
                    else Console.Write( "\t");
                }
            }
            Console.WriteLine();






        }
    }
    class Mergearray
    {
        static void alterante(int[] arr1, int[]arr2,int n1,int n2, int[] arr3)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while(i<n1 && j < n2)
            {
                arr3[k++] = arr1[i++];
                arr3[k++] = arr2[j++];

            }
            while (i < n1)
            {
                arr3[k++] = arr1[i++];
            }
            while (j < n2)
            { arr3[k++] = arr2[j++];}
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] {1,3,5,7,9,11};
            int n1 = arr1.Length;
            int[] arr2 = new int[] {2,4,6,3,8};
            int n2 = arr2.Length;
            int[] arr3 = new int[n1 + n2];
            Mergearray.alterante(arr1, arr2, n1, n2, arr3);
            Console.WriteLine("1st array:");
            for (int i = 0; i< n1; i++)
            {
                Console.Write(arr1[i] + "\n");
            }
            Console.WriteLine("2nd array:");
            for (int i =0;i<n2; i++)
            {
                Console.Write(arr2[i] + " \n");
            }
            Console.WriteLine("array  after merging");
            for (int i = 0; i < n1 + n2; i++)
            {
                Console.Write(arr3[i] + " ");
            }
           


        }
    }
    class Sort
    {
        //

    }

}
