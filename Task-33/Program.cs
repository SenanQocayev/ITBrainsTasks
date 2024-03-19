
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33
{
    
        internal class Program
        {

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("1. add\n" + "2.show\n" + "3.remove\n" + "4.update\n" + "5.search\n" + "6.exit\n");
                    Console.WriteLine("selecet operation : ");
                    int operation = Convert.ToInt32(Console.ReadLine());
                    switch (operation)
                    {
                        case 1:
                            Student.Add();
                            break;


                        case 2:
                            Student.show();

                            break;



                        case 3:

                            Student.remove();
                            break;

                        case 4:
                            Student.search();
                            break;

                    }

                }
            }

        }
    }

    





