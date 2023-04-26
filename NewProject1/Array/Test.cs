using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NewProject1.Array
{
    internal class Test
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            Console.WriteLine("enter values for row and column");

            for (int i = 0; i<arr.GetLength(0); i++)
            {
                for (int j = 0;j<arr.GetLength(1); j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());
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



        }
        


    }
}
