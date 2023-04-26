using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace NewProject1.OOPS
{
    internal class Methods
    { // set id,name in dispaydata method and diplay it using creating object of method class
        int id;
        string name;
        public void Displaydata()
        {
            id = 123;
            name = "vaibhav patil";
            Console.WriteLine("id = " + id + " " + "name = " + name);
        }
        static void Main(string[] args)
        {
            Methods m = new Methods();
            m.Displaydata();

        }
    }
    class Student
    {
        // getid method call inside displaydata method using this keyword.
        int id;
        string name;
        int age;

        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void getid()
        {
            Console.WriteLine("id = " + id);
        }


        public void Displaydata()
        {
            this.getid();
            Console.WriteLine("name = " + name + "age = " + age);
        }
        public static void Main(string[] args)
        {
            Student m = new Student(123, "vaibhav patil", 23);
            m.Displaydata();

        }
    }
    // pass by value example.
    class Passbyvalue
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine("variable value before calling method = " + x); // x =100
            Addingnumberbyfive(x);   // x = 110
            Console.WriteLine("variable value after calling method = " + x); //x = 100;

        }
        public static void Addingnumberbyfive(int number)
        {
            number = number + 10;
            Console.WriteLine("variable value inside method = " + number);

        }
    }
    class Passbyref
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine("variable value before calling method = " + x); // x = 100
            multiply(ref x); // x = 10000
            Console.WriteLine("value after calling method = " + x); // x = 10000.



        }
        public static void multiply(ref int value)
        {
            value = value * value;
            Console.WriteLine("value inside function = " + value);
        }
    }
    class Account2
    {
        // account class with deposit , withdraw, checkbalance , account information.
        int Acc_no;
        string name;
        float Amount;
        public Account2(int Acc_no, string name, float amount)
        {
            this.Acc_no = Acc_no;
            this.name = name;
            this.Amount = amount;

        }
        public void Accountinformation()
        {
            Console.WriteLine("account number = " + Acc_no + "\n" + "name = " + name + "\n" + "initial amount" + Amount);
        }
        public float Depositamount(float deposit)
        {
            deposit += Amount;
            Console.WriteLine("total amount after deposit = " + deposit);

            return deposit;





        }
        public void Withdraw()
        {
            Console.WriteLine("withdraw amount = " + Amount);
        }

        public void CheckBalance()
        {
            //Amount = Depositamount(40000);

            Console.WriteLine("check balance = " + Amount);
        }
        static void Main(string[] args)
        {
            Account2 a = new Account2(12345, "vaibhav patil", 10000);
            a.Accountinformation();
            a.Depositamount(40000);
            //a.WithdrawAmount(10000);
            a.CheckBalance();
            a.Withdraw();


        }
    }
    class Student3
    {
        //per centage with return type method + without return type mthod to display data
        int id;
        string name;
        int m1;
        int m2;
        int m3;

        public Student3(int id, string name, int m1, int m2, int m3)
        {
            this.id = id;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public void Studentdata()
        {
            Console.WriteLine(id + name + m1 + m2 + m3);
        }
        public double Percentage()
        {
            int sum = m1 + m2 + m3;
            int percent = sum * 100 / 300;
            Console.WriteLine("percentage = " + percent);
            return percent;

        }
        static void Main(string[] args)
        {
            Student3 s = new Student3(123, "vaibhav", 30, 40, 50);
            s.Studentdata();
            s.Percentage();

        }
    }
    class Arithmatic
    {
        // arithmatic operation without parameter.
        int a;
        int b;
        public Arithmatic(int a, int b)
        {
            this.a = a; this.b = b;
        }
        public void Addition()
        {
            Console.WriteLine("addition of A and B = " + (a + b));
        }
        public void Multiply()
        {
            Console.WriteLine("multiplication of a and b = " + (a * b));
        }
        public void Substract()
        {
            Console.WriteLine("substraction of a and b = " + (a - b));
        }
        public void Divide()
        {
            double c = a / b;
            Console.WriteLine("substraction of a and b = " + c);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number for arithmatic operation");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number for arithmatic operation");
            int num2 = int.Parse(Console.ReadLine());


            Arithmatic a = new Arithmatic(num1, num2);
            a.Addition();
            a.Substract();
            a.Multiply();
            a.Divide();



        }
    }
    class Arithmatic2
    {
        // arithmatic operation with seprate method + parameter passing.
        int a;
        int b;
       
        public void Addition(int a, int b)
        {
            Console.WriteLine("addition of A and B = " + (a + b));
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine("multiplication of a and b = " + (a * b));
        }
        public void Substract(int a, int b)
        {
            Console.WriteLine("substraction of a and b = " + (a - b));
        }
        public void Divide(int a, int b)
        {
            float c = a / b;
            Console.WriteLine(" dividation of a and b = " + c);
        }
        static void Main(string[] args)
        {
            Arithmatic2 b = new Arithmatic2();
            Console.WriteLine("enter 2 number for addition");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            b.Addition(num1,num2);

            Console.WriteLine("enter 2 number for substration");
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            b.Substract(num3, num4);

            Console.WriteLine("enter 2 number for multiplication");
            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());
            b.Multiply(num5, num6);

            Console.WriteLine("enter 2 number fo dividation");
            int num7 = int.Parse(Console.ReadLine());
            int num8 = int.Parse(Console.ReadLine());
            b.Divide(num7, num8);




        }






    }
    class Arithmatic3
    {
        // arithmatic operation with each seprate method and return type
        public int Addition(int a, int b)
        {
            int c= a + b;
            Console.WriteLine("addition of a and b =" + c);
            return c;
           
        }
        public int Substract(int a, int b)
        {
            int c= a - b;
            Console.WriteLine("substration of a and b = " + c);
            return c;
        }
        public int Multiply(int a, int b)
        {
            int c = a * b;
            Console.WriteLine(" multiplication of a and b = " + c);
            return c;
        }
        public int Divide(int a, int b)
        {
            int c = a / b;
            Console.WriteLine(" dividation of a and b = " + c);
            return c;
        }
        static void Main(string[] args)
        {
            Arithmatic3 c = new Arithmatic3();
            c.Addition(1, 2);
            c.Substract(4, 5);
            c.Divide(6, 7);
            c.Multiply(8, 9);
        }

    }
    class Square
    {
        int num;
        public Square(int num)
        {
            this.num = num;
        }

        public void Squareroot()
        {
            int ans = num * num;
            Console.WriteLine("square root of given number using void method= " +ans);

        }
        // method with parameter and no return type.
        public void Squareroot(int num){
            int ans = num * num;
            Console.WriteLine("square root of given number using parameter method, without return type = " + ans);

        }
        // method with return type and no parameter.
        public int Squarerootn()
        {
            int ans = num * num;
            Console.WriteLine("square root of number using return type method = " + ans);
            return ans;
        }
        // method with return type and paramter
        public int Squarerootn(int num)
        {
            int ans = num * num;
            Console.WriteLine("square root of number using return type, and parameter method = " + ans);
            return ans;
        }
        public static void Main(string[] args)
        {
            Square s = new Square(4);
            s.Squareroot();
            Console.WriteLine("enter number to find its square root");
            int num = int.Parse(Console.ReadLine());
            s.Squareroot(num);
            s.Squarerootn();
            s.Squarerootn(num);
           

        }
    }
    class Cube
    {
        int num;
        public Cube(int num)
        {
            this.num = num;
        }

        public void Cuberoot()
        {
            int ans = num * num* num;
            Console.WriteLine("cuube  root of given number using void method= " + ans);

        }
        // method with parameter and no return type.
        public void Cuberoot(int num)
        {
            int ans = num * num *num;
            Console.WriteLine(" cube root of given number using parameter method, without return type = " + ans);

        }
        // method with return type and no parameter.
        public int Cuberootn()
        {
            int ans = num * num *num;
            Console.WriteLine(" cube  root of number using return type method = " + ans);
            return ans;
        }
        // method with return type and paramter
        public int Cuberootn(int num)
        {
            int ans = num * num *num;
            Console.WriteLine(" Cube root of number using return type, and parameter method = " + ans);
            return ans;
        }
        public static void Main(string[] args)
        {
                Cube  s = new Cube(4);
            s.Cuberoot();
            Console.WriteLine("enter number to find its square root");
            int num = int.Parse(Console.ReadLine());
            s.Cuberoot(num);
            s.Cuberootn();
            s.Cuberootn(num);


        }
    }

}