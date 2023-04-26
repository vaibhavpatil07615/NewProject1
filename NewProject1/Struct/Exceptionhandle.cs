using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Struct
{
    internal class Exceptionhandle
    {
        static void Main(string[] args)
        {
         /*   int x = 20;
            try
            {
                Console.WriteLine(x/0);
            }
            catch (ArithmeticException e)
            {
                // Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }*/


            int[] a = { 1, 4, 5 };
            try
            {
                Console.WriteLine(a[7]/0);
               

            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException p)
            {
                Console.WriteLine(p.Message);
                Console.WriteLine(p);
            }

           

        }


    }
    /*class Nested
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                count++;

            }
            try
            {
                count++;
            }
            try
            {
                try
                {
                    count++;
                    throw new Exception();

                }
                catch(Exception e)
                {
                    count++;
                    throw new Exception();

                }
            }
            catch (Exception e)
            {
                count++;
                throw new Exception();
            }
            catch(Exception e1)
            {
                count++;
                throw new Exception();
            }

        }
        Catch(Exception e2)
        {
            C

        }
    }*/
    // homework problem
    class Catch
    {
        static void Main(string[] args)
        {
            int x = 0;
            int div = 0;
            try
            {
                div  = 50 / x;
                Console.WriteLine("not execute");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine(" attempt divide by zero ");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("finally block");
            }

            Console.WriteLine("result is : " + div);

        }
    }
}
