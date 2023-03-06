using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NewProject1.NewFolder
{
    internal class Celcius { 

    static void Main(string[] args)
    {

        Console.WriteLine("convert input celcius to fahrenite");
        Console.WriteLine("input tempertature in celcius");
        int cel = int.Parse(Console.ReadLine());
        float f = 1.8f;
        float farhe = (f * cel) + 32;
        Console.WriteLine("temerature in farhenite = " + farhe);
        Console.ReadLine();


        Console.WriteLine("convert input fahrenite to celcius");
        Console.WriteLine("input temperature in fahrenite");
        int fehre = int.Parse(Console.ReadLine());
        //float f2 = 1.8f;
        float celci = (fehre - 32) / f;
        Console.WriteLine(" temperature in celcius = " + celci);
        Console.ReadLine();









    }
}
class Leapyear

{
    static void Main(string[] args)
    {
        Console.WriteLine("check input year is leap year or not");
        Console.WriteLine("please enter year");
        int year = int.Parse(Console.ReadLine());
        if (year % 4 == 0)
        {
            Console.WriteLine("the year is leap year");
        }
        else if
            (year % 400 == 0)
        {
            Console.WriteLine("the year is leap year");

        }
        else Console.WriteLine("the year is not leap year");


        Console.WriteLine("check number is divisible by 5 and 11");
        Console.WriteLine("enter number");

        int n2 = int.Parse(Console.ReadLine());
        if (n2 % 5 == 0)
        {
            Console.WriteLine("input no. is divisible by 5");
        }
        else if (n2 % 11 == 0)
        {
            Console.WriteLine("no. is disible by 11");
        }
        else Console.WriteLine("no. is not divisible by 5 and 11");

        Console.WriteLine(" find out maximum between 3 number ");
        Console.WriteLine(" enter 3 numbers to check");
        int n1 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        if (n1 > n3 && n1 > n4)
        {
            Console.WriteLine("the maximum between 3 number = " + n1);
        }
        else if (n3 > n1 && n3 > n4)
        {
            Console.WriteLine("the maximum between 3 number = " + n3);
        }
        else
            Console.WriteLine("the maximum between 3 number = " + n4);


    }
}
class Characters

{
    static void Main(string[] args)
    {




        Console.WriteLine("check character is vowel or consonant");

        char c = char.Parse(Console.ReadLine());
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            Console.WriteLine("character is vowel");
        }
        else
        {
            Console.WriteLine("character is consonant");
        }





        Console.WriteLine("check character is alphabet or digit");
        char key = char.Parse(Console.ReadLine());
        if ((key >= 'a' && key <= 'z') || (key >= 'A' && key <= 'Z'))
        {
            Console.WriteLine("input character is alphabet");
        }
        else if (key >= '0' && key <= '9')
        {
            Console.WriteLine("input character is digit");
        }
        else
            Console.WriteLine("input character is special character ");
        Console.ReadLine();

        Console.WriteLine(" find 1st and last digit and addition of it");
        Console.WriteLine("please enter number");
        int num = int.Parse(Console.ReadLine());

        //int last = num % 10;
        int first = 0;
        int sum = 0;
        int digit = 0;
        int temp = num;
        int last = 0;
        while (num > 0)
        {
            digit++;
            num = num / 10;


        }
        if (digit <= 3)
        {
            num = temp;

            last = num % 10;

        }





        while (num > 0)
        {
            first = num % 10;
            num = num / 10;


        }



        sum = first + last;
        Console.WriteLine(sum);

        Console.ReadLine();







    }
}

class Salary
{
    static void Main(string[] args)
    {
        Console.WriteLine("please enter salary");
        int salary = int.Parse(Console.ReadLine());
        float hra;
        float da;
        float gross = 1;
        if (salary <= 10000)
        {
            hra = 0.2f;
            da = 0.8f;
            gross = ((salary * hra * da) + salary);

            Console.WriteLine(" gross salary = " + gross);
            Console.ReadLine();


        }
        if (salary <= 20000)
        {
            hra = 0.25f;
            da = 0.9f;
            gross = ((salary * hra * da) + salary);
            Console.WriteLine(" gross salary = " + gross);
            Console.ReadLine();
        }
        if (salary >= 20000)
        {

            hra = 0.30f;
            da = 0.95f;
            gross = ((salary * hra * da) + salary);
            Console.WriteLine(" gross salary = " + gross);
            Console.ReadLine();

        }

    }
}
class Electricbill
{
    static void Main(string[] args)
    {
        Console.WriteLine("please enter units");
        int unit = int.Parse(Console.ReadLine());
        float charge;
        float bill = 1;

        if (unit >= 1 && unit <= 50)
        {
            charge = 0.50f;
            bill = unit * charge;
            Console.WriteLine("total bill = " + bill);
            Console.ReadLine();
        }
        else if (unit >= 51 && unit <= 100)
        {
            charge = 0.75f;
            bill = unit * charge;
            Console.WriteLine("total bill = " + bill);
            Console.ReadLine();

        }
        else if (unit >= 101 && unit <= 200)
        {
            charge = 1.20f;
            bill = unit * charge;
            Console.WriteLine("total bill = " + bill);
            Console.ReadLine();

        }
        else if (unit >= 250)
        {
            charge = 1.50f;
            float penalty = 0.2f;
            bill = unit * charge + penalty;
            Console.WriteLine("total bill = " + bill);
            Console.ReadLine();
        }
    }
}
}
