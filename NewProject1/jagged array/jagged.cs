using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.jagged_array
{
    internal class jagged
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[4][];
            jagged[0] = new int[4];
            jagged[1] = new int[5];
            jagged[2] = new int[3];
            jagged[3] = new int[6];

            Console.WriteLine("enter columne element");
            for (int i = 0;i< jagged.Length;i++)
            {
                for (int j = 0; j< jagged[i].Length; j++)
                {
                    jagged[i][j] = int.Parse(Console.ReadLine());
                }



            }
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write ( jagged[i] [j])  ;
                }
                Console.WriteLine();



            }

        }


    }
    class Collection
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add("vaibhav");
            arr.Add("patil");
            arr.Add(82.20);
            arr.Add(3);
            arr.Add(4);
           /* foreach(var item in arr)
            {
                Console.WriteLine(item);
            }*/
            arr.Insert(2, "rajendra");

            arr.Remove(4);
            arr.RemoveAt(4);

            //arr.Remove

            Console.WriteLine($"total size of arraylist {arr.Count}");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
