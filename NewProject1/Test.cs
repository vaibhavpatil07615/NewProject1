using NewProject1.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NewProject1
{
    internal class Test
    {
        // sort half array in decending and half array in ascending array.
        public static void Ascending(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length / 2; j++)
                {
                    if (arr[j] <arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                   // Console.WriteLine(arr[i]);
                }
                for (int j = arr.Length/2; j<arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i =0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public 




        static void Main(string[] args)
        {
            int[] a = new int[5];

            for (int i =0;i< a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Test.Ascending(a);
          
        }
    }
    class SortArray
    {
        public static void Sort(int[] arr, int[] arr1, int[]arr2)
        {

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    arr1[i] = arr[i];


                   
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    arr2[i] = arr[i];



                   

                }




            }
            Console.WriteLine("even array");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }


                
               
                   
                
              

            
           /* for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }*/

        }

        static void Main(string[] args)
        {
            int[] a = new int[8];
            int[]b = new int[8];

            int[] c = new int[8];
            Console.WriteLine("enter array element");
            for (int i = 0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            SortArray.Sort(a,b,c);


        }
    }
    public class Employe
    {
        public int id;
        public string name;
        public int age;
        public int salary;
        public long code;

        static int num;
        static int max = 50;
        //create an array of Employee
        static Employe[] emp = new Employe[max];


        int i = int.Parse(Console.ReadLine());

        public Employe(int id, string name, int age, int salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public static void CreateEmployee()
        {
            Employe[] emp = new Employe[max];
          //  Console.WriteLine("how many records want to store");
           // int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num - 1; i++)
            {
                Console.WriteLine("Enter Employee info\n", i + 1);
                Console.WriteLine("Enter Id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Salary");
                int salary = int.Parse(Console.ReadLine());

                emp[i] = new Employe(id, name, age, salary);

            }

            foreach (Employe e in emp)
            {
                if (e != null)
                {
                    //Console.WriteLine(e);
                    Console.WriteLine("Id=" + e.id);
                    Console.WriteLine("name= " + e.name);
                    Console.WriteLine("age= " + e.age);
                    Console.WriteLine("salary= " + e.salary);
                }
            }

        }
        public static void InsertEmployee()
        {
            if (num < max)
            {
                int i = num;
                num++;

                Console.Write("Enter the info of employee ");
                Console.Write("Id");
                emp[i].id = int.Parse(Console.ReadLine());
                Console.Write("Name");
                emp[i].name = Console.ReadLine();
                Console.Write("Age");
                emp[i].age = int.Parse(Console.ReadLine());
                Console.Write("Salary");
                emp[i].salary = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Employee table is full");
            }
            ShowMenu();
        }


        public static void UpdateRecord()
        {
            Console.WriteLine("Enter employee Id to serach record ");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                // if data is found
                if (emp[i].id == id)
                {
                    Console.WriteLine("Id" + emp[i].id);
                    Console.WriteLine("Name" + emp[i].name);
                    Console.WriteLine("Age" + emp[i].age);
                    Console.WriteLine("salary" + emp[i].salary);
                    break;
                }
                Console.WriteLine("Employee with id is not found");
            }
            ShowMenu();

        }

        // TO delete record/Index
        public static void DeleteIndex(int i)
        {
            for (int j = i; j < num - 1; j++)
            {
                emp[j].name = emp[j + 1].name;
                emp[j].age = emp[j + 1].age;
                emp[j].salary = emp[j + 1].salary;
            }
            return;
        }
        //To delete record
        public static void DeleteRecord(int id)
        {
            Console.WriteLine("enter employee id to dlt record");
            id = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (emp[i].id == id)
                {
                    DeleteIndex(i);
                    num--;
                    break;
                }
            }
            ShowMenu();

        }

        public static void ShowMenu()
        {
            Console.WriteLine("Employee Management System");
            Console.WriteLine("Choose Options:\n");
            Console.Write("1.CreateEmployee\n");
            Console.Write("2.Insert new Employee\n");
            Console.Write("3.Delete Record\n");
            Console.Write("4.Search Record\n");
            Console.Write("5.Exit\n");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                CreateEmployee();
            }
            else if (option == 2)
            {
                InsertEmployee();
            }
            else if (option == 3)
            {
                UpdateRecord();
            }
            else if (option == 4)
            {
                DeleteRecord(1);
            }
            else if (option == 5)
            {
                return;
            }
            else
            {
                Console.WriteLine("Error");
                ShowMenu();
            }
        }
        static public void Main(string[] args)
        {
            ShowMenu();

        }
    }
    class Sortstring // sort each word of string as per its length .
    {
        static void Main(string[] args)
        {
            string[] s = new string[5];
            for (int i = 0;i< s.Length;i++)
            {
                s[i] = Console.ReadLine();
            }
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                    if (s[i].Length > s[j].Length)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;

                    }
                    if (s[i].Length == s[j].Length)
                    {
                        if (s[i].CompareTo(s[j]) == 1)
                        {
                            string temp = s[i];
                            s[i] = s[j];
                            s[j] = temp;
                        }
                    }
                }
            }
            foreach(string st in s)
            {
                Console.WriteLine(st);
            }
        }
    }
    class Sorting2
    {
        public static void Sort(string[] s)
        {
            for (int i = 0;i< s.Length;i++)
            {
                for (int j = i+1;i < s.Length;j++)
                {
                    if (s[i].CompareTo(s[j]) == 1)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;


                    }
                }
            }
            Console.WriteLine(string.Join(" " , s));
        }
        static void Main(string[] args)
        {
            string[] s = new string[5];
            Console.WriteLine("enter 5 city name");
            for (int i =0;i<s.Length;i++)
            {
                s[i] = Console.ReadLine();
            }

        }
    }


    class  Employee
    {
         void Employeedata()
        {

        }
    }
    class Manager : Employee
    {
         void Employeedata()
        {

        }
    }
} 
