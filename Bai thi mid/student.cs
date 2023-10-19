using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_thi_mid
{
    internal class student
    {
        public string Id;
        public string Name;
        public string Gender;
        public int Age;
        public string DateOfBirth;
        public string Class;
        public double Mark1, Mark2, Mark3;

        public student(string id, string name, string gender, int age, string dateOfBirth, string studentClass, double mark1, double mark2, double mark3)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
            DateOfBirth = dateOfBirth;
            Class = studentClass;
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }

        public string id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string gender
        {
            get { return Gender; }
            set { Gender = value; }
        }

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        public string dateOfBirth
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }

        public string studentClass
        {
           get { return Class; }
           set { Class = value; }
        }

        public double mark1
        {
            get { return Mark1; } set { Mark1 = value; }
        }
        public double mark2
        {
            get { return Mark2; } set { Mark2 = value; }
        }
        public double mark3
        {
            get { return Mark3; } set { Mark3 = value; }
        }
    }
}
