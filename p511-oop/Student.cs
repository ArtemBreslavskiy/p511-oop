using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    class Student
    {
        private DateTime _birthday;
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string EducationalInstitution { get; set; }
        public string EducationalInstitutionCity { get; set; }
        public string EducationalInstitutionCountry { get; set; }
        public string Group { get; set; }
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                int age = DateTime.Now.Year - value.Year;

                if (DateTime.Now.Day < value.Day)
                {
                    age--;
                }
                if (age > 0 && age < 120)
                {
                    _birthday = value;
                }
            }
        }

        public Student(

            string fullName = "Unknown",
            string phoneNumber = "Unknown",
            string city = "Unknown",
            string country = "Unknown",
            string educationalInstitution = "Unknown",
            string educationalInstitutionCity = "Unknown",
            string educationalInstitutionCounty = "Unknown",
            string group = "Unknown",
            DateTime birthday = default
            )
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            City = city;
            Country = country;
            EducationalInstitution = educationalInstitution;
            EducationalInstitutionCity = educationalInstitutionCity;
            EducationalInstitutionCountry = educationalInstitutionCounty;
            Group = group;
            Birthday = birthday;
        }

        public void PrintValue()
        {
            Console.WriteLine($"\tFullName: {FullName}\n");
            Console.WriteLine($"\tBirthday: {_birthday}\n");
            Console.WriteLine($"\tPhoneNumber: {PhoneNumber}\n");
            Console.WriteLine($"\tCity: {City}\n");
            Console.WriteLine($"\tCountry: {Country}\n");
            Console.WriteLine($"\tEducationalInstitution: {EducationalInstitution}\n");
            Console.WriteLine($"\tEducationalInstitutionCity: {EducationalInstitutionCity}\n");
            Console.WriteLine($"\tEducationalInstitutionCountry: {EducationalInstitutionCountry}\n");
            Console.WriteLine($"\tGroup: {Group}");
        }
    }
}
