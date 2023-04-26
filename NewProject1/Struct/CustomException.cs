using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Struct
{
    class NumException:Exception
    {
        public NumException()
        {
            Console.WriteLine("string is not in range");
        }
        public NumException(string message) : base(message)
        {

        }






    }
    class NumException2 : Exception
    {
        public NumException2()
        {
            Console.WriteLine("string contain alphabet");
        }
        public NumException2(string message) : base(message)
        {

        }
    }
    class Checkstring
    {
        public void check(string str)
        {
           if (str.Length<10 || str.Length > 10)
            {
                throw new NumException(" size of mobile number is not valid");
            }
          
        }
      

        public void Check2(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                {
                    throw new NumException2(" number  contain alphabet");
                }



               //else Console.WriteLine("valid number");
            }
            Console.WriteLine("valid mobile number");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();  
            Checkstring d = new Checkstring();
            Checkstring v = new Checkstring();

            
            try
            {
                d.check(s);
                v.Check2(s);
              

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
    class CheckNum : Exception
    {
        public CheckNum()
        {
            Console.WriteLine("number is not binary");
        }
        public CheckNum(string m) : base(m)
        {

        }

    }
    class Check
    {
        public void checknumber(int num)
        {
            bool isdigit = false;
            while (num > 0)
            {
                
                int digit = num % 10;
                if (digit == 0 || digit == 1)
                {
                   isdigit = true;
                    break;
                }
                


               
        

              
                num = num / 10;

            }
            if (isdigit == true)
            {
                throw new CheckNum(" binary number");

            }
            else
                Console.WriteLine(" not binary number");



        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            Check c = new Check();
            try
            {
                c.checknumber(n);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
