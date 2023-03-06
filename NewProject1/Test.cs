using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{
    internal class Test
    {
        int stuid;
        string name;
        int sub1;
        int sub2;
        int sub3;
        int sub4;
        int sub5;
        int percentage;


        public Test(int stuid, string name, int sub1, int sub2, int sub3, int sub4, int sub5)
        {
            this.stuid = stuid;
            this.name = name;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
            this.sub4 = sub4;
            this.sub5 = sub5;

        }
        public void per()
        {
            int addition = sub1 + sub2 + sub3 + sub4 + sub5;
            percentage = addition * 100 / 500;
            Console.WriteLine("percentage = " + percentage);
        }
        public void grade()
        {
            if (percentage > 75)
            {
                Console.WriteLine("grade A");
            }
            else if (percentage > 40 && percentage < 75)
            {
                Console.WriteLine("grade B");
            }
            else Console.WriteLine("grade c");

        }
        public void display()
        {
            Console.WriteLine("student id = " + stuid + "\n" + "student name = " + name + "\n" + "subject1 marks = " + sub1 + "\n" + "subject2 marks = " + sub2 + "\n" + "subject3 marks = " + sub3 + "\n" + "subject4 marks = " + sub4 + "\n" + "subject5 marks = " + sub5);
            Console.WriteLine("percentage = " + percentage);

        }
        static void Main(string[] args)
        {
            Test s = new Test(121, "vaibhav patil", 40, 50, 60, 70, 80);
            s.per();
            s.grade();
            s.display();


        }
    }




    class Krushnamurthy
    {
        public void number(int num)

        {
            int fact;
            int sum = 0;
            int temp = num;

            while (num > 0)
            {
                int digit = num % 10;
                fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact *= i;

                }
                sum += fact;
                num /= 10;

                


            }
            num = temp;
            if (num == sum)
            {
                Console.WriteLine("krushnamurthy number");
            }
            else Console.WriteLine("no krushnamurthy number");


        }
        public static void Main(string[] args)
        {
            Krushnamurthy k = new Krushnamurthy();
            Console.WriteLine("please enter number");
            int x = int.Parse(Console.ReadLine());
            k.number(x);

        }

    }
} 
