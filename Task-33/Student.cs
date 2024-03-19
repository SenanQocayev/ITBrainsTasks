using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_33
{
    internal class Student
    
        {
            public static List<Student> students = new List<Student>();

            public int ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int No { get; set; }
            public static int count;

            public Student(int iD, string name, string surname)
            {
                ID = iD;
                Name = name;
                Surname = surname;
                count++;
                No = count;
            }

            public static void Add()
            {
                Console.WriteLine("sagird adini daxil et :");
                string sagirdadi = Console.ReadLine();

                Console.WriteLine("sagird soyadini daxil edin :");
                string sagirdsoyadi = Console.ReadLine();

                Random r = new Random();
                int id = r.Next(1000, 10000);

                Student st = new Student(id, sagirdadi, sagirdsoyadi);
                students.Add(st);
                Console.WriteLine("stuednt added");




            }
            public static void show()
            {

                foreach (var s in students)
                {

                    Console.WriteLine(s.No + "\nad:" + s.Name + "\nsoyad" + s.Surname + "\nid:" + s.ID);


                }
            }
            public static void remove()
            {
                Console.WriteLine("Nomre daxil et");
                int nomre = Convert.ToInt32(Console.ReadLine());
                foreach (var s in students)
                {
                    if (s.No == nomre)
                    {
                        students.Remove(s);
                        Console.WriteLine("silindi");
                        return;
                    }
                }
                Console.WriteLine("Tapilmadi");
            }
            public static void search()
            {
                Console.WriteLine("Nomreni daxil edin");
                int a = Convert.ToInt32(Console.ReadLine());
                foreach (var s in students)
                {
                    if (a == s.No)
                    {
                        Console.WriteLine(s.No + "\nad:" + s.Name + "\nsoyad" + s.Surname + "\nid:" + s.ID);

                    }
                }
            }

        }
    }

