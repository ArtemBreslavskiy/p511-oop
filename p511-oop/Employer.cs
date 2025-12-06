using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Employer
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private string position;
        private string descriptionOfWork;

        private DateTime birthday {  get; set; }
        public string FirstName
        {
            get { return firstName; }
            set { if (value == "") firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { if (value == "") lastName = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { if (value == "") phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { if (value == "") email = value; }
        }
        public string Position
        {
            get { return position; }
            set { if (value == "") position = value; }
        }
        public string DescriptionOfWork
        {
            get { return descriptionOfWork; }
            set { if (value == "") descriptionOfWork = value; }
        }

        public Employer(
            string firstName = "Unknown",
            string lastName = "Unknown",
            DateTime birthday = default,
            string phoneNumber = "Unknown",
            string email = "Unknown",
            string position = "Unknown",
            string descriptionOfWork = "Unknown"
            )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.position = position;
            this.descriptionOfWork = descriptionOfWork;
        }

        public void PrintEmployerData()
        {
            Console.WriteLine($"\n\tИмя: {firstName}\n");
            Console.WriteLine($"\tФамилия: {lastName}\n");
            Console.WriteLine($"\tДата рождения: {birthday}\n");
            Console.WriteLine($"\tНомер телефона: {phoneNumber}\n");
            Console.WriteLine($"\tАдрес электронной почты: {email}\n");
            Console.WriteLine($"\tДолжность: {position}\n");
            Console.WriteLine($"\tОписание работы: {descriptionOfWork}\n\n");
        }

        public void InputNewBirthday()
        {
            Console.Write("Введите новую дату рождения:");
            birthday = Convert.ToDateTime(Console.ReadLine());
        }
        public void InputNewFirstName()
        {
            Console.Write("Введите новое имя:");
            FirstName = Console.ReadLine();
        }
        public void InputNewLastName()
        {
            Console.Write("Введите новую фамилию:");
            LastName = Console.ReadLine();
        }
        public void InputNewPhoneNumber()
        {
            Console.Write("Введите новый номер телефона:");
            PhoneNumber = Console.ReadLine();
        }
        public void InputNewEmail()
        {
            Console.Write("Введите новый адрес электронной почты:");
            Email = Console.ReadLine();
        }
        public void InputNewPosition()
        {
            Console.Write("Введите новую должность:");
            Position = Console.ReadLine();
        }
        public void InputNewDescriptionOfWork()
        {
            Console.Write("Введите описание работы:");
            DescriptionOfWork = Console.ReadLine();
        }
    }
}
