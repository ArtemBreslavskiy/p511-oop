using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Student
    {
        protected string className = "Student";
        protected string firstName;
        protected string lastName;
        protected string groupNumber;
        protected string phoneNumber;
        protected string emailAdress;
        protected float averageScore;

        public Student(
            string firstName = "Unknown",
            string lastName = "Unknown",
            string groupNumber = "Unknown",
            string phoneNumber = "Unknown",
            string emailAdress = "Unknown",
            float averageScore = -1
            )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.groupNumber = groupNumber;
            this.phoneNumber = phoneNumber;
            this.emailAdress = emailAdress;
            this.averageScore = averageScore;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{className}:");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Номер группы: {groupNumber}");
            Console.WriteLine($"Номер телефона: {phoneNumber}");
            Console.WriteLine($"Адрес электронной почты: {emailAdress}");
            Console.WriteLine($"Средний бал: {averageScore}");
        }
    }
}
