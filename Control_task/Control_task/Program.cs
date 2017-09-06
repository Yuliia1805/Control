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
            const int thisyear = 2017;
            Student[] students;
            students = new Student[5];

            Console.WriteLine("Hello! Please, enter information about 5 students: second name, year of birth, group, faculty");

            
                for(int j = 0; j < students.Length; j++)
                {
                    Console.Write("Enter second name of the {0} student: ", j + 1);
                    students[j].secondName = Console.ReadLine();
                }
                Console.WriteLine();
                for(int k = 0; k < students.Length; k++)
                {
                    Console.Write("Enter year of birth of {0} student: ", k + 1);
                    students[k].yearofbirth = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                for(int l = 0; l < students.Length; l++)
                {
                    Console.Write("Enter group name of {0} student: ", l + 1);
                    students[l].group = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                for(int m = 0; m < students.Length; m++)
                {
                    Console.Write("Enter faculty of the {0} student: ", m + 1);
                    students[m].faculty = Console.ReadLine();
                }

            Console.WriteLine();
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Choose the action: ");
                Console.WriteLine("1. Show the list of students");
                Console.WriteLine("2. Show the avarage age of students");
                Console.WriteLine("3. Show the maximum and minimum age of students and their second names");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Make your choice, please: ");
                char c = char.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                int studentsage;
            
            double avarage = 0;
                int maxAge = 0;
                int minAge = 0;
             
               

               if (c == '1')

                {
                    Console.WriteLine("List of students: ");
                    for (int j = 0; j < students.Length; j++)
                    {
                        Console.Write("\n" + students[j].secondName);
                    }
                }
                Console.WriteLine();

                if (c == '2')
                {
                    for (int k = 0; k < students.Length; k++)
                    {
                        studentsage = thisyear - students[k].yearofbirth;
                        avarage += studentsage;
                    }
                    avarage = avarage / 5;
                    Console.WriteLine("The avarage age of students is: " + avarage);
                }
                Console.WriteLine();

                if (c == '3')
                {
                    for (int k = 0; k < students.Length; k++)
                    {
                       
                        studentsage = thisyear - students[k].yearofbirth;
                        int[] studentages = { studentsage };
                        minAge = studentages[0];
                        maxAge = studentages[0];

                        for (int a = 0; a < studentages.Length; a++)
                        {
                            if (studentages[a] < minAge)
                            {
                                minAge = studentages[a];
                            }
                            if (studentages[a] > maxAge)
                            {
                                maxAge = studentages[a];
                            }
                        }
                    }
                    Console.WriteLine("Minimum age is: " + minAge);
                    Console.WriteLine("Maximum age is: " + maxAge);
                }














            }
            
            Console.ReadLine(); 
        }
    }
}
