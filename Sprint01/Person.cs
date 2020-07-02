using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint01
{
    public class Person
    {
        protected int yearOfBirth;
        protected string healthInfo;
        protected string name;

        public Person(int yearOfBirth, string name, string healthInfo)
        {
            this.yearOfBirth = yearOfBirth;
            this.healthInfo = healthInfo;
            this.name = name;
        }

        public string GetHealthStatus() => name + ": " + yearOfBirth + ". " + healthInfo;
    }

    public class Child : Person
    {
        private string childIDNumber;

        public Child(int yearOfBirth, string name, string healthInfo, string childIDNumber) : base(yearOfBirth, name, healthInfo)
        {
            this.childIDNumber = childIDNumber;
        }     
        
        public override string ToString()
        {
            return $"{name} {childIDNumber}";
        }
    }

    public class Adult : Person
    {
        private string passportNumber;

        public Adult(int yearOfBirth, string name, string healthInfo, string passportNumber) : base(yearOfBirth, name, healthInfo)
        {
            this.passportNumber = passportNumber;
        }

        public override string ToString()
        {
            return $"{name} {passportNumber}";
        }
    }
}
