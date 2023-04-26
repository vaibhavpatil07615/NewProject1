using NewProject1.OOPS;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Project
{
    internal class Program
    {
        // struct is group of diffrent type of related variable in 1 place;
        struct student
        {
            public string stnumber;
            public string stname;
            public string Gender;
            public float Marathi;
            public float English;
            public float Science;
            public float Math;
            public float Computer;
            public float total;
           



        };
        static void Main(string[] args)
        {
            const int MAX = 20;
            try
            {
                student[] st = new student[MAX]; // array object.
                int itemcount = 0;
                int choice;
                string confirm;
                do
                {
                    // show menu
                    displaymenu();
                    Console.Write("enter your choice(1-6):");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            add(st, ref itemcount);
                            break;
                            case 2:
                            delete(st, ref itemcount);
                            break;
                            case 3:
                            update(st,itemcount); break;
                            case 4:
                            viewall(st,itemcount); break;
                            case 5:
                            Top5(st,itemcount); break;
                            case 6:
                            find(st, itemcount);
                            break;
                        default:
                            Console.WriteLine("invalid");
                            break;

                    }
                    Console.Write("press y or Y to continue");
                    confirm = Console.ReadLine().ToString();
                    Console.Clear();




                } while (confirm == "y" || confirm == "Y");
            }
            catch (FormatException) { Console.WriteLine("invalid input"); }
            Console.ReadLine();
        }
        static void displaymenu()
        {
            Console.WriteLine("=========================\n MENU ===================================    ");
            Console.WriteLine("1.add student record");
            Console.WriteLine("2. delete student record");
            Console.WriteLine("3.update student record");
            Console.WriteLine("4.view all student record");
           // Console.WriteLine("5. show top 5 student");
            Console.WriteLine("6.find a student by id");
            Console.WriteLine("******************************************");

        }
        // method to add new record
        static void add(student[] st, ref int itemcount)
        {
        Again:
            Console.WriteLine("==================================================");
            Console.Write("enter students id:");
            st[itemcount].stnumber = Console.ReadLine().ToString();
            if (search(st, st[itemcount].stnumber, itemcount) != -1)
            {
                Console.Clear();
                Console.WriteLine("the ID number you enter is already exist");
                goto Again;

            }
            Console.Write("enter students name:");
            st[itemcount].stname = Console.ReadLine().ToString();
            Console.Write("enter students GENDER (F or M):");
            st[itemcount].Gender = Console.ReadLine().ToString();
            Console.Write("enter students marathi marks");
            st[itemcount].Marathi = float.Parse(Console.ReadLine());
            Console.Write("enter students english marks ");
            st[itemcount].English = float.Parse(Console.ReadLine());
            Console.Write("enter students science marks ");
            st[itemcount].Science = float.Parse(Console.ReadLine());
            Console.Write("enter students math marks");
            st[itemcount].Math = float.Parse(Console.ReadLine());
            Console.Write("enter students computer marks");
            st[itemcount].Computer = float.Parse(Console.ReadLine());
            st[itemcount].total = st[itemcount].Marathi + st[itemcount].English + st[itemcount].Science + st[itemcount].Math + st[itemcount].Computer;
            ++itemcount;



        }
        // deleting data of student.
        static void delete(student[] st,ref int itemcount)
        {
            
            string id;
            int index;
            if (itemcount > 0)
            {
                Console.WriteLine("========================/n deleting the data==============");
                Console.Write("enter students ID:");
                id = Console.ReadLine();
                index = search(st, id.ToString(), itemcount);
                if ((index != -1) && (itemcount != 0))
                {
                    if (index == (itemcount - 1))
                    {
                        clean(st,index);
                        clean(st,index);
                        --itemcount;
                        Console.WriteLine("the record was deleted");
                    }
                    else
                    {
                        for(int i = index;i<itemcount-1;i++)
                        {
                            st[i] = st[i+1];
                            clean(st, itemcount);
                            --itemcount;

                        }
                    }
                }
                else Console.WriteLine("the record not exit. check the id again");
            }
            else Console.WriteLine("no record to delete");
        }
        // update data of student
        static void update(student[] st,int itemcount)
        {
            string id;
            int column_index;
            Console.WriteLine("=====================\n update student data ====================\n");
            Console.WriteLine("enter students ID:");
            id = Console.ReadLine();
            Console.WriteLine("which field do you want to update(1-7)");
            Console.WriteLine("1:students name");
            Console.WriteLine("2:students gender");
            Console.WriteLine("3: students marathi marks");
            Console.WriteLine("3: students english marks");
            Console.WriteLine("4 : students science marks");
            Console.WriteLine("5: students math marks");
            Console.WriteLine("6 : studensts computer marks");
            Console.WriteLine(" *******************************************\n");
            column_index = int.Parse(Console.ReadLine());
            int index = search(st, id.ToString(), itemcount);
            if((index!=-1 ) && (index != 0))
            {
                if(column_index == 1)
                {
                    Console.Write("enter students NAME:");
                    st[index].stname = Console.ReadLine().ToString();


                }
                else if (column_index == 2)
                {
                    Console.Write("enter students Gender(F or M);");
                    st[index].Gender = Console.ReadLine().ToString();

                }
                else if (column_index == 3)
                {
                    Console.Write("enter students marathi marks:");
                    st[index].Marathi = float.Parse(Console.ReadLine());
                }
                else if (column_index == 4)
                {
                    Console.Write("enter students english marks");
                    st[index].English = float.Parse(Console.ReadLine());
                }
                else if (column_index == 5)
                {
                    Console.Write("enter students science marks");
                    st[index].Science = float.Parse(Console.ReadLine());
                }
                else if (column_index == 6)
                {
                    Console.Write("enter students math marks");
                    st[index].Math = float.Parse(Console.ReadLine());
                }
                else if (column_index == 7)
                {
                    Console.Write("enter students computer marks");
                    st[index].Computer = float.Parse(Console.ReadLine());
                }
                else Console.WriteLine("invalid column input");
                st[index].total = st[index].Marathi + st[index].English + st[index].Science + st[index].Math + st[index].Computer;

            }
            else Console.WriteLine("the record not exist check id and try again");


        }
        // view all data of students
        static void viewall(student[]st,int itemcount)
        {
            int i = 0;
            Console.WriteLine("============================\n view all data of student===============\n");
            Console.WriteLine();
            Console.WriteLine("{0,-5}\t{1,-20}{2,-10}{3,-10}{4,-10}{5,-9}{6,-11}{7,-15}{8,-4}(column index)","0","1","2","3","4","5","6","7","8");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("{0,-5}\t{1,-15}\t{2,-5}\t{3,-10}{4,-10}{5,-5}\t{6,-5}\t{7,-5}\t{8,-5}","ID","NAME","GENDER","MARATHI","ENGLISH","SCIENCE","MATH","COMPUTER","AVERAGE");
            Console.WriteLine("======================================================================================");
            while(i < itemcount)
            {
                if (st[i].stnumber != null)
                {
                    Console.Write("{0,-5}\t{1,-20}{2,-10}", st[i].stnumber, st[i].stname, st[i].Gender);
                    Console.Write("{0,-9}{1,-9}{2,-9}", st[i].Marathi, st[i].English, st[i].Science);
                    Console.Write("{0,-12}{1,-15}{2,-10}", st[i].Math, st[i].Computer, st[i].total/5);
                    Console.WriteLine("\n-----------------------------------------------------------------------\n");

                }
                i = i + 1;

            }
        }
        // sorting the data of all student by top5
        static void Top5(student[] st, int itemcount)
        {
            Console.WriteLine("===================================\n top5 student ============================\n");
            float topst = st[0].total;
            int index = 8;
            if (itemcount > 2)
            {
                for (int j = 0; j < itemcount; ++j)

                    if (topst <= st[j + 1].total)
                    {
                        topst = st[j + 1].total;
                        index = j + 1;
                    }



            }
            else if (itemcount == 1)
            {
                index = 8;
                topst = st[8].total;

            }
            else Console.WriteLine("no record found");
            if (index != -1)
            {
                Console.WriteLine("{0,-5}\t{1,-15}\t{2,-5}", "ID", "NAME", "AVERRAGE");
                Console.WriteLine("{0,-5}\t {1,-15}\t{2,-5}", st[index].stnumber, st[index].stname, topst / 5);
            }
        }
            // searching record of student by id
            static void find(student[]st,int itemcount)
            {
                string id;
                Console.Write("enter students id:");
                id = Console.ReadLine();
                int index = search(st, id.ToString(), itemcount);
                if (index != -1)
                {
                    Console.Write("{0,-5}\t{1,-20}{2,-5}", st[index].stnumber, st[index].stname, st[index].Gender);
                    Console.Write("{0,-5}{1,-5}{2,-5}", st[index].Marathi, st[index].English, st[index].Science);
                    Console.Write("{0,-5}{1,-5}{2,-5}", st[index].Math, st[index].Computer, st[index].total/5);
                    Console.WriteLine();
                }
                else Console.WriteLine("the record does not exit");

            }
            // code for search used by finding deleting updating,the data of student
            // also adding new data if student ID is already present.
            static int search(student[]st,string id,int itemcount)
            {
                int found = -1;
                for (int i = 0; i < itemcount && found == -1 ; i++) {

                    if (st[i].stnumber == id)
                        found = i;
                    else found = -1;
                }
                return found;

            }
            static void clean(student[]st,int index)
            {
                st[index].stnumber = null;
                st[index].stname = null;
                st[index].Gender = null;
                st[index].Marathi = 0;
                st[index].English = 0;
                st[index].Science = 0;
                st[index].Math = 0;
                st[index].Computer = 0;
                st[index].total = 0;
            }


        















    }
   
}
