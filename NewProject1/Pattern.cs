using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{






    class Pattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to print pattern");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine(" ");



            }

        }
    }




        class Pattern2
        {
            static void Main(string[] args)
            {

                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" ");
                }

                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 4; j >= i; j--)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }




                for (int i = 4; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");

                    }
                    Console.WriteLine();





                }




            }
        }



            class Pattern3

            {
                static void Main(string[] args)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (j == 1 || j == 3 || j == 5)
                            {
                                Console.Write(" * " + " ");

                            }
                            else Console.Write(" 0 " + " ");
                        }
                        Console.WriteLine();
                    }

                }
            }
            class Pattern4
            {
                static void Main(string[] args)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int J = 1; J <= 5; J++)
                        {
                            if (i == 3 || J == 3)
                            {
                                Console.Write("*");
                            }
                            else Console.Write(" ");

                        }
                        Console.WriteLine(" ");
                    }
                }
            }
            class Pattern5
            {
                static void Main(string[] args)
                {
                    for (char i = 'A'; i <= 'D'; i++)
                    {
                        for (char j = 'A'; j <= i; j++)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }

            class Pattern6
            {
                static void Main(string[] args)
                {
                    for (char i = 'A'; i <= 'D'; i++)
                    {
                        for (char j = 'D'; j >= i; j--)
                        {
                            Console.Write(j + " ");

                        }
                        Console.WriteLine();
                    }
                    for (char i = 'D'; i >= 'A'; i--)
                    {
                        for (char j = 'A'; j <= i; j++)
                        {
                            Console.Write(j + " ");
                        }
                        Console.WriteLine(" ");
                    }



                    for (int i = 1; i <= 4; i++)
                    {
                        for (int j = 1; j <= 4; j++)
                        {
                            if (j == 1 || j == 4 || i == j)
                            {
                                Console.Write("*");
                            }
                            else { Console.Write(" "); }
                        }
                        Console.WriteLine(" ");
                    }


                    for (int i = 1; i <= 4; i++)
                    {
                        for (int j = 1; j <= 4; j++)
                        {
                            if (j == 1)
                            {
                                Console.Write(" A ");
                            }
                            else if (j == 4)
                            {
                                Console.Write(" D ");
                            }




                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine(" ");
                    }





                }






            }
    class Pattern7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ReadLine();

            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
                Console.ReadLine();
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write("-");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                Console.ReadLine();
            }

        }

    }

}
    
   
    

            





        
    

        

    


        
    

      


