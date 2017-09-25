using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_task
{
    class Program
    {
        struct Student
        {
            public string secondName;
            public int yearofbirth;
            public int group;
            public string faculty;
        }
        static void Main(string[] args)
        {
            char c;
            const int thisyear = 2017;
            Student[] students;
            students = new Student[3];
            
            Console.WriteLine("Hello! Please, enter information about 5 students: second name, year of birth, group, faculty");


            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Enter second name of the {0} student: ", i + 1);
                students[i].secondName = Console.ReadLine();

                Console.Write("\nEnter year of birth of {0} student: ", i + 1);
                students[i].yearofbirth = int.Parse(Console.ReadLine());

                Console.Write("\nEnter group name of {0} student: ", i + 1);
                students[i].group = int.Parse(Console.ReadLine());

                Console.Write("\nEnter faculty of the {0} student: ", i + 1);
                students[i].faculty = Console.ReadLine();
            }

            
            do
            {
                Console.WriteLine("Choose the action: ");
                Console.WriteLine("1. Show the list of students");
                Console.WriteLine("2. Show the avarage age of students");
                Console.WriteLine("3. Show the maximum and minimum age of students and their second names");
                Console.WriteLine("4.Sort by second name");
                Console.WriteLine("5.Sort by year of birth");
                Console.WriteLine("6.Sort by group");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Make your choice, please: ");
                c = char.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                int studentsage;

                double avarage = 0;
                int maxAge = 0;
                int minAge = 0;

                switch (c)
                {
                    case '1':
                        {
                            Console.WriteLine("List of students: ");
                            for (int i = 0; i < students.Length; i++)
                            {
                                Console.Write("\n" + students[i].secondName);
                            }
                            break;
                        }
                        

                    case '2':
                        {
                            for (int i = 0; i < students.Length; i++)
                            {
                                studentsage = thisyear - students[i].yearofbirth;
                                avarage += studentsage;
                            }
                            avarage = avarage / 5;
                            Console.WriteLine("The avarage age of students is: " + avarage);
                            break;
                        }



                    case '3':
                        {
                            for (int i = 0; i < students.Length; i++)
                            {

                                studentsage = thisyear - students[i].yearofbirth;
                                int[] studentages = { studentsage };
                                minAge = studentages[0];
                                maxAge = studentages[0];

                                for (int j = 0; j < studentages.Length; j++)
                                {
                                    if (studentages[j] < minAge)
                                    {
                                        minAge = studentages[j];
                                    }
                                    if (studentages[j] > maxAge)
                                    {
                                        maxAge = studentages[j];
                                    }
                                }
                            }

                            Console.WriteLine("Minimum age is: " + minAge);
                            Console.WriteLine("Maximum age is: " + maxAge);
                            break;
                        }
                    case '4':
                        {
                            Console.WriteLine("The database is sorted by second names of students: ");
                            Array.Sort(students, (x, y) => String.Compare(x.secondName, y.secondName));

                            for (int i = 0; i < students.Length; i++)
                            {
                                Console.WriteLine("{0}. Second name: {1}, year of birth: {2}, facultee: {3}, group: {4}", i + 1, students[i].secondName, students[i].yearofbirth, students[i].faculty, students[i].group);
                            }
                            break;
                        }
                    case '5':
                        {
                            Student temp;
                            for (int i = 0; i < students.Length; i++)
                            {
                                for (int j = 0; j < students.Length - 1; j++)
                                {
                                    if (students[j].yearofbirth > students[j + 1].yearofbirth)
                                    {
                                        temp = students[j + 1];
                                        students[j + 1] = students[j];
                                        students[j] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("Sorting by year of beirth: ");
                            for (int i = 0; i < students.Length; i++)
                            {
                                Console.WriteLine("Year of birth: {0}, student: {1}, faculty: {2}, group: {3}", students[i].yearofbirth, students[i].secondName, students[i].faculty, students[i].group);
                            }
                            break;
                        }
                    case '6':
                        {
                            Student temp;
                            for (int i = 0; i < students.Length; i++)
                            {
                                for (int j = 0; j < students.Length - 1; j++)
                                {
                                    if (students[i].group > students[i].group)
                                    {
                                        temp = students[i];
                                        students[i] = students[j];
                                        students[j] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("Sorting by group: ");
                            for (int i = 0; i < students.Length; i++)
                            {
                                Console.WriteLine("Group: {0}, student: {1}, yearof birth: {2}, faculty: {3},", students[i].group, students[i].secondName, students[i].yearofbirth, students[i].faculty);
                            }
                            break;
                        }
                } 
            } while (c != '7');
            Console.ReadLine();
        }
    }
}
