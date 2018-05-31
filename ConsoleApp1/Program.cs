using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        private static List<Student> list = new List<Student>();

        static void Main(string[] args)
        {
            generate();

            /*while (true)
            {
                Console.WriteLine("nhap roolnumber: ");
                string roolNumber = Console.ReadLine();
                Console.WriteLine("nhap name: ");
                string name = Console.ReadLine();
                Console.WriteLine("nhap email: ");
                string email = Console.ReadLine();
                Console.WriteLine("nhap phone: ");
                string phone = Console.ReadLine();
                Student student = new Student(roolNumber,name,email,phone);
                list.Add(student);
                Console.WriteLine(student.ToString());
                Console.WriteLine("Hello World!");
                Console.WriteLine("ban co muon nhap tiep khong(y/n)");
                string answers = Console.ReadLine();
                if (answers.Equals("k"))
                {
                    break;
                }

               
            }*/
            foreach (var f in list)
            {
                Console.WriteLine(f.ToString());
            }
        }

        private static void display()
        {
            foreach (var studen in list)
            {
                Console.WriteLine(studen.ToString());
            }
        }

        private static void searchStudent()
        {
            Console.WriteLine("please input name: ");
            var name = Console.ReadLine();
            foreach (var stu in list)
            {
                if (stu.Name1 == name)
                {
                    Console.WriteLine(stu.ToString());
                }
            }
        }
        private static void addStudent()
        {
            while (true)
            {
                Console.WriteLine("nhap roolnumber: ");
                string roolNumber = Console.ReadLine();
                Console.WriteLine("nhap name: ");
                string name = Console.ReadLine();
                Console.WriteLine("nhap email: ");
                string email = Console.ReadLine();
                Console.WriteLine("nhap phone: ");
                string phone = Console.ReadLine();
                Student student = new Student(roolNumber, name, email, phone);
                list.Add(student);
                Console.WriteLine(student.ToString());
                Console.WriteLine("Hello World!");
                Console.WriteLine("ban co muon nhap tiep khong(y/n)");
                string answers = Console.ReadLine();
                if (answers.Equals("k"))
                {
                    break;
                }
            }
        }

        private static void generate()
        {
            while (true)
            {
                Console.WriteLine("1.add student");
                Console.WriteLine("2.Display student");
                Console.WriteLine("3.Search student");
                Console.WriteLine("4.Exit");
                Console.WriteLine("please input choise");
                var choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine(choice);
                switch (choice)
                {
                    case 1:
                        addStudent();
                        break;
                    case 2:
                        display();
                        break;
                    case 3:
                        searchStudent();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}