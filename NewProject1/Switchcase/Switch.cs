using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Switchcase
{
    internal class Switch

    {
        static void Main(string[] args)
        {
            Console.WriteLine("display 1 to 5 number in words");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {

                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                default:
                    Console.WriteLine("the number is not valid");
                    break;
            }
            Console.ReadLine();


            Console.WriteLine("disply week days from input");
            Console.WriteLine("enter any number from 1 to 7");
            int num2 = int.Parse(Console.ReadLine());
            switch (num2)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine(" wednesday");
                    break;
                case 4:
                    Console.WriteLine(" thursday");
                    break;
                case 5:
                    Console.WriteLine(" friday ");
                    break;
                case 6:
                    Console.WriteLine(" saturday");
                    break;
                case 7:
                    Console.WriteLine(" sunday");
                    break;
                default:
                    Console.WriteLine("number not in range");
                    break;
            }
            Console.ReadLine();



            Console.WriteLine("find out area or circle, rectangle, square");
            Console.WriteLine("1 =  area of circle\n 2 = area of rectangle\n 3 = area of square\n 4 = area of triangle ");
            Console.WriteLine("enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter radius of circle");
                    float radius = float.Parse(Console.ReadLine());
                    float pi = 3.14f;
                    Console.WriteLine("area of circle = " + (pi * radius * radius));
                    break;
                case 2:
                    Console.WriteLine("enter length and breadth of rectangle");
                    int length = int.Parse(Console.ReadLine());
                    int breadth = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of rectangle = " + (length * breadth));
                    break;
                case 3:
                    Console.WriteLine("enter side of square");
                    int side = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of square = " + (side * side));
                    break;
                case 4:
                    Console.WriteLine("enter breath and height of triangle");
                    int height = int.Parse(Console.ReadLine());
                    int breadth2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of tringle = " + (1 / 2 * height * breadth2));
                    break;
            }
            Console.ReadLine();


        }
    }
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("simple calculator");
            Console.WriteLine(" enter 2 number to perform operation");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" 1 = addition\n  2 = substraction\n 3 = multiplication\n 4 = division ");
            Console.WriteLine("enter your choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("addition of 2 number = " + (n1 + n2));
                    break;
                case 2:

                    Console.WriteLine(" substration  of 2 number = " + (n1 - n2));
                    break;
                case 3:
                    Console.WriteLine(" multiplication of 2 number = " + (n1 * n2));
                    break;
                case 4:
                    Console.WriteLine(" division of 2 number = " + (n1 / n2));
                    break;
                default:
                    Console.WriteLine("numbers not in range");
                    break;



            }
            Console.ReadLine();
            Console.WriteLine("write code to check character is vowel or consonant ");
            Console.WriteLine("enter any character to check vowel or consonant");
            char c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case 'a':
                    Console.WriteLine("character is vowel");
                    break;
                case 'e':
                    Console.WriteLine("character is vowel");
                    break;
                case 'i':
                    Console.WriteLine("character is vowel");
                    break;
                case 'o':
                    Console.WriteLine("character is vowel");
                    break;
                case 'u':
                    Console.WriteLine("character is vowel");
                    break;
                default:
                    Console.WriteLine("the character is consonant");
                    break;

            }
        }
    }
}

