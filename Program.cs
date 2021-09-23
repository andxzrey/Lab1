using System;

namespace Lab1
{
    enum Faculty
    {
        None,
        Arts,
        Classics,
        Commerce,
        Economics,
        Education,
        Enginering,
        Graduate_Studies,
        Humanities,
        Law,
        Management,
        Musics,
        Computer_Sciense_Math_and_Physics,
    }

    enum Marks
    {
        Poor = 1,
        Bad,
        Satisfactory,
        Good,
        Excellent
    }
    
    enum Subjects
    {
        Maths,
        Physics,
        IT,
        Chemistry,
        Philosophy
    }

    class Person
    {
        public Person()
        {
               
        }
        public Person(string Name, string Surname, string Patronymic, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.Age = Age;
            ID = Guid.NewGuid();
        }

        public Guid ID;
        public string Name;
        public string Surname;
        public string Patronymic;
        public int Age;

        public void PrintPersonInfo()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Information about person:");
            Console.ResetColor();
            Console.WriteLine($"Id: {ID}");
            Console.WriteLine($"Name: {Name} \t| Surname: {Surname} \t| Patronymic: {Patronymic}");
            Console.WriteLine($"Age: {Age}\n");
        }
        public string GetFullName()
        {
            return $"{Surname} {Name} {Patronymic}\n";
        }
    }

    class Student : Person
    {
        public Student(string Name, string Surname, string Patronymic, int Age, string group)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.Age = Age;
            ID = Guid.NewGuid();
            this.group = group;
            faculty = int.Parse(group.Remove(group.IndexOf("-")));
            magister = group.Contains("M");
            course = Char.GetNumericValue(group, 3);
        }
        
        private string group;
        private int faculty;
        private double course;
        bool magister;

        private int[] Marks()
        {
            Random rnd = new Random();
            int[] marks = new int[5];
            int sumOfMarks = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = rnd.Next(0, 6);
                Console.Write($"{(Subjects)i}: {marks[i]}\t");
                sumOfMarks += marks[i];
            }
            double averageOfMarks = sumOfMarks / 5.0;
            Console.WriteLine($"\nAverage: {averageOfMarks} = {(Marks)averageOfMarks}");
            return marks;
        }

        public void PrintStudentInfo()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Information about student:");
            Console.ResetColor();
            Console.WriteLine($"Id: {ID}");
            Console.WriteLine($"Name: {Name} \t| Surname: {Surname} \t| Patronymic: {Patronymic}");
            Console.WriteLine($"Age: {Age}");
            Console.Write($"Faculty: {(Faculty)faculty}\tGroup: {group}\t");
            if (magister)
            {
                
                Console.WriteLine($"Course: {course+4}");
            }
            else
            {
                Console.WriteLine($"Course: {course}");
            }
            Marks();
            Console.WriteLine();
        }
    }

    class Teacher : Person
    {
        private string Department;
        public Teacher(string Name, string Surname, string Patronymic, int Age, string Department)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.Age = Age;
            this.Department = Department;
            ID = Guid.NewGuid();
        }
        public void PrintTeacherInfo()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Information about teacher:");
            Console.ResetColor();
            Console.WriteLine($"Id: {ID}");
            Console.WriteLine($"Name: {Name} \t| Surname: {Surname} \t| Patronymic: {Patronymic}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Department: {Department}\n");
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Person a = new Person("Andrey", "Gluschuk", "Sergeevich", 19);
            Person b = new Person(Name: "Ivan", Surname: "Ivanov", "James", 12);
            Student student = new Student("Student", "KSU", "", 19, "4-145M");
            Teacher teacher = new Teacher("Teacher", "KSU", "", 26, "Maths");

            a.PrintPersonInfo();
            b.PrintPersonInfo();
            student.PrintPersonInfo();
            teacher.PrintPersonInfo();
            
            string fullnameA = a.GetFullName();
            Console.WriteLine(fullnameA);

            student.PrintStudentInfo();
            teacher.PrintTeacherInfo();
        }
    }
}
