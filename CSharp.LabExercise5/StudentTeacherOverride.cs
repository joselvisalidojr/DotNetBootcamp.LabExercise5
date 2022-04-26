using System;

namespace CSharp.LabExercise5.Solution3
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }

    class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }
        public void Study()
        {
            Console.WriteLine("Student {0} is studying.", Name);
        }
    }

    class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }
        public void Explain()
        {
            Console.WriteLine("Teacher {0} is explaining.", Name);
        }
    }

    class StudentTeacherOverride
    {
        public StudentTeacherOverride()
        {

            Person[] people = new Person[3];

            for (int i = 0; i < people.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("Teacher Name: ");
                    people[i] = new Teacher(Console.ReadLine());
                }

                else
                {
                    Console.Write("Student Name: ");
                    people[i] = new Student(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < people.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Teacher {((Teacher)people[i]).ToString()} is Explaining");
                }
                else
                {
                    Console.WriteLine($"Student {((Student)people[i]).ToString()} is Studying");
                }
            }

            Console.Write("\nPress any key to return...");
            Console.ReadKey();

            MainMenu myMainMenu = new MainMenu();
            myMainMenu.Start();
        }
    }
}