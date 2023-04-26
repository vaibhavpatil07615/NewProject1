using NewProject1.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Videoassignment2
{
    //salary of teacher using abstract class, abstract method,parameterized constructor.
  abstract class Teacher
    {
        int Tid;
       string Tname;
       double Tmobile;

        public Teacher(int Tid, string Tname,double Tmobile )
        {
            this.Tid = Tid;
            this.Tname = Tname;
            this.Tmobile = Tmobile;

        }
        public abstract void salary();

    }
    class Hourlybase : Teacher
    {
        int hours;
        int rateperhour;
        public Hourlybase(int Tid, string Tname, double Tmobile,int hours, int rateperhour) : base(Tid, Tname, Tmobile)
        {
            this.hours = hours;
            this.rateperhour = rateperhour;
        }

        public override void salary()
        {
            Console.WriteLine("salary of visiting teacher ="+(hours*rateperhour));
           // Console.WriteLine(Tid+Tname+Tmobile);
        }

    }
    class Salarybased : Teacher
    {
        int monthlysalary;
        public Salarybased(int Tid, string Tname, double Tmobile,int salary):base(Tid, Tname, Tmobile)
        {
            this.monthlysalary = salary;

        }
        public override void salary()
        {
            Console.WriteLine("monthly salary of teacher = " +monthlysalary);

        }
    }
    class Abstract4
    {
        static void Main(string[] args)
        {
            Teacher p = new Hourlybase(123,"vaibhav",7767070356,3,1000);
            p.salary();
            Teacher t = new Salarybased(1234, "v r p", 8208832166, 20000);
            t.salary();
            
        }
    }
    //2nd problem
    //getter,setter method

 

    
   
}
