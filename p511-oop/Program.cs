using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
            new Student("Alex", "Doe", 21),
            new Student("Jim", "Doe", 19),
            new Student("Tim", "Doe", 20),
            new Student("Tom", "Doe", 22),
            new Student("Bob", "Doe", 18),
            new Student("John", "Doe", 19),
            new Student("Donald", "Doe", 20),
            new Student("Tim", "Doe", 18)
        };

            Console.Write("Введите длинну группы: ");
            int groupLength = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Length; i++)
            {
                students[i].groupName = $"Group {i / groupLength + 1}";
            }

            for (int i = 0; i < students.Length; i++)
            {
                students[i].Introduce();
            }
        }

        class Student
        {
            string firstName;
            string lastName;
            int age;
            public string groupName;

            public Student(string firstName, string lastName, int age)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
            }

            public void Introduce()
            {
                Console.WriteLine($"Привет, меня зовут {firstName} {lastName}, мне {age} лет, моя группа {groupName}");
            }
        }
    }
}
