using NewProject1.OOPS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.TestAssignment
{
    internal class Testassignment4
    // 1. count even and odd number from array.
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 15, 17, 19, 20, 34, 36, 40 };
            Console.WriteLine("input array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count1++;
                }


            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    count2++;
                }


            }
            Console.WriteLine("no of even element in array = " + count1);
            Console.WriteLine("no of odd element in array = " + count2);



        }

    }
     class Test
        // predict output = 101,102.
     {
         static int mcCartyCounter = 100;
         public static int mcCarthy(int n)
         {
             mcCartyCounter++;
             if (n > 100)
                 return n - 10;
             else
                 return mcCarthy(n + 11);
         }
         public static void Main(string[] args)
         {
 
              Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
         }
     }

    class Minimum
    {
        //3.find minimum frequency character from array.
        static void Main(string[] args)
        {
            char[] c = new char[7];
            Console.WriteLine("enter" + (c.Length) + "element");
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = char.Parse(Console.ReadLine());

            }
            //int sum = 0;
            for (int i = 0; i < c.Length; i++)
            {


                int count = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (c[k] == c[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {

                    for (int j = i + 1; j < c.Length; j++)

                    {
                        if (c[j] == c[i])
                        {
                            count++;
                        }

                    }

                    if (count == 1)
                    {
                        Console.WriteLine(c[i]);

                    }





                }
            }
        }






    }
    class Pen
    {
        //4. pen problem of get,set property.
        string refill;
        int caplength;
        string brand;
        string materialtype;
        int width;
        string inkcolour;
        int length;
        string nib;
        public string Refill
        {
            set { refill = value; }
            get { return refill; }
        }
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }





        public string Inkcolour
        {
            get { return inkcolour; }
            set { inkcolour = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public string Nib
        {
            get { return nib; }
            set { nib = value; }
        }




        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }

        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }





        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.Refill = "ball point refill";
            p.Caplength = 2;
            p.Brand = "reynold";
            p.Materialtype = "stainless steel";
            p.Width = 3;
            p.Inkcolour = "blue";
            p.Nib = "ballpoint";
            p.Length = 4;
            Console.WriteLine(p.Refill);
            Console.WriteLine(p.Caplength);
            Console.WriteLine(p.Brand);
            Console.WriteLine(p.Materialtype);
            Console.WriteLine(p.Width);
            Console.WriteLine(p.Inkcolour);
            Console.WriteLine(p.Nib);
            Console.WriteLine(p.Length);






        }
    }
















    class Sortzero
    {
        // 6. seprate zero from nonzero element

        static void Main(string[] args)
        {
            int[] a = { 5, 6, 0, 0, 9, 8, 0, 0, 6, 7, 8 };
            int n = a.Length;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] != 0)
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
    class Duplicate
    {
        //7.  remove duplicate element from array.
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            int[] b = new int[7];
            Console.WriteLine("enter array element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            //int sum = 0;
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

                    if (count == 1)
                    {
                        b[i] = arr[i];

                    }







                    Console.WriteLine(b[i]);

                }

            }
        }
    }


    class Gear
    {
        string Auto;
        string Manual;
        public Gear(string Auto, string Manual)
        {
            this.Auto = Auto;
            this.Manual = Manual;

        }
        public void display1()
        {
            Console.WriteLine("gear type = " + Auto);
        }
    }


    class Subengine
    {
        string subenginetype;
        //  Engine engine;
        public Subengine(string subenginetype)
        {
            this.subenginetype = subenginetype;

        }
        public void display2()
        {
            Console.WriteLine(" sub engine type = " + subenginetype);
        }

    }


    class Engine
    {
        int EngineID;
        int Last_engine_clean_date;
        Subengine ssubengine;

        public Engine(int EngineID, int Last_engine_clean_date, Subengine ssubengine)
        {
            this.EngineID = EngineID;
            this.Last_engine_clean_date = Last_engine_clean_date;
            this.ssubengine = ssubengine;
        }
        public void display3()
        {
            Console.WriteLine("engine id = " + EngineID + "\n" + "last engine clean date = " + Last_engine_clean_date + "\n" + "sub engine = " + ssubengine);
        }


    }
    class Car
    { // contentment problem.
        int carID;
        string carcolour;
        Engine engine;
        Gear geaar;
        public Car(int  carID, string carcolour, Engine engine,Gear geaar)
        {
            this.carID = carID;
            this.carcolour = carcolour;
            this.engine = engine;
            this.geaar = geaar;
        }
        public void display()
        {
            Console.WriteLine("car id = " +  carID +"\n" + " car colour = " + carcolour + "\n" + "engine = " + engine + "\n" +"gear = "+ geaar);

        }


    }
   
   
  
    class Contentment
    {



        public static void Main(string[] args)
        {


            Subengine s = new Subengine("petrol engine");
            s.display2();
            Engine n = new Engine(1234, 20032023, s);
            n.display3();
            Gear g = new Gear("auto", "manual");
            g.display1();
            Car c = new Car(123, "red", n, g);
            c.display();








        }
    }

            
            

    


















        class Numbers3
        { // predict the output = 0,2,4,6,8
            public static void Main(string[] args)
            {
                int[]var = new int[10];
                for (int i = 0; i < 10; ++i)
                {
                    var[i] = i;
                    Console.WriteLine(var[i] + " ");
                    i++;
                }
            }
        }

   /* public class ArrayOuput
    {
        public static void Main(string[] args)
        {
            int [,]a1, a2;
            a1 ={ 1,2,3};
            a2 = new string[a1.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = a1[i];
            }
            for (int i = 0; i < a2.Length(); i++)
            {

                Console.WriteLine(a2[i]);
            }
        }
    }*/


    class Reverse
        {
            // reverse row of 2d array.
            static int m = 2; // no of row
            static int n = 3; // no of  column
            static void reversearray(int[,] arr)
            {
                for (int i = 0; i < m; i++)
                {
                    int start = 0;
                    int end = n - 1;
                    while (start < end)
                    {
                        int temp = arr[i, start];
                        arr[i, start] = arr[i, end];
                        arr[i, end] = temp;
                        start++;
                        end--;
                    }

                }
                // print array after reversing.
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            static void Main(string[] args)
            {
                int[,] arr = { { 1, 2, 3 },
                          { 4, 5, 6 },
                            };
                reversearray(arr);
            }
        }


        class MaximumRow
        {
            // 12. maximum from row.


            public static void Maxelement(int no_of_rows, int[][] arr)
            {
                int i = 0;
                int max = 0;
                int[] result = new int[no_of_rows];
                while (i < no_of_rows)
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
            private static void printArray(int[] result)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine(result[i]);
                }




            }
            static void Main(string[] args)
            {
                int[][] arr = new int[][]
               {
                new int []{3,5,7,8},
                new int []{10,23,25,},

               };
                Maxelement(2, arr);
            }
        }
        class Numbers
        {
            // check multiplier of 3,5,and 3 and 5 
            static void Main(string[] args)
            {
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                for (int i = 1; i <= 50; i++)
                {
                    if (i % 3 == 0)
                    {
                        count1++;
                        Console.WriteLine("buzz");
                    }
                    else if (i % 5 == 0)
                    {
                        count2++;
                        Console.WriteLine("fizz");
                    }
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        count3++;
                        Console.WriteLine("buzzfizz");
                    }
                    else Console.WriteLine(i);
                }
                Console.WriteLine("no of times buzz comes = " + count1);
                Console.WriteLine("no of times fizz comes = " + count2);
                Console.WriteLine("no of times buzzfizz comes = " + count3);

            }
        }

    
}

