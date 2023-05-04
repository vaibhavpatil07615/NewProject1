using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myprojectadvance.Collection.Assignment
{

    public class Student
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public double percent { get; set; }

    }
    public class StudentCrud
    {
        private List<Student> students;
        public StudentCrud()
        {
            students = new List<Student>();
        }
        public void Addstudent(Student stud)
        {
            students.Add(stud);
        }
        public void UpdateStudent(Student stud)
        {
            foreach (Student s in students)
            {
                if (s.rollno == stud.rollno)
                {
                    s.name = stud.name;
                    s.percent = stud.percent;
                }

            }
        }
        public void Deletestudent(int Rollno)
        {
            foreach (Student s in students)
            {
                if (s.rollno == Rollno)
                {
                    students.Remove(s);
                }
            }
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public Student GetstudentById(int Rollno)
        {
            Student op = new Student();
            foreach (Student p in students)
            {
                if (p.rollno == Rollno)
                {
                    op = p;
                    break;
                }
            }
            return op;
        }
    }
    public class Maindata
    {
        static void Main(string[] args)
        {
            StudentCrud db = new StudentCrud();
            char op;
            do
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. View All");
                Console.WriteLine("5. View by roll no ");
                Console.WriteLine("6. student with percentage less than 60");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Student s = new Student();
                        Console.WriteLine("enter roll no");
                        s.rollno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter name of student");
                        s.name = Console.ReadLine();
                        Console.WriteLine("enter percentage");
                        s.percent = Convert.ToInt64(Console.ReadLine());
                        db.Addstudent(s);
                        break;
                    case 2:
                        Student v = new Student();
                        Console.WriteLine("enter student roll no");
                        v.rollno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter student name");
                        v.name = Console.ReadLine();
                        Console.WriteLine("enter student percentage");
                        v.percent = Convert.ToInt64(Console.ReadLine());
                        db.UpdateStudent(v);
                        break;
                    case 3:
                        Student t = new Student();
                        Console.WriteLine("enter student roll no");
                        int Rollno = Convert.ToInt32(Console.ReadLine());
                        db.Deletestudent(Rollno);
                        break;
                    case 4:
                        List<Student> list = db.GetStudents();
                        Console.WriteLine(" roll no.\tname  \t percentage");
                        foreach (Student c in list)
                        {
                            Console.WriteLine($"{c.rollno} \t {c.name} \t  {c.percent}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter roll no");
                        int rollno2 = Convert.ToInt32(Console.ReadLine());
                        Student item2 = db.GetstudentById(rollno2);
                        Console.WriteLine("Roll no  \t name \t percentage");
                        Console.WriteLine($"{item2.rollno} \t {item2.name} \t {item2.percent}");
                        break;
                    default:
                        Console.WriteLine("No option available");
                        break;
                }
                Console.WriteLine("Do you want to continue ?? ");
                Console.WriteLine("yes = y  no = N");

                op = Convert.ToChar(Console.ReadLine());
            }
            while (op == 'y');
        }
    }















}
    





