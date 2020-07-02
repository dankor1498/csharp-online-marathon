using System;

namespace Sprint01
{
    public class MyAccessModifiers
    {
        private const byte averageMiddleAge = 50;

        private int birthYear;
        protected string personalInfo;
        private protected string IdNumber;
        internal string Name { get; set; }
        public string NickName { get; internal set; }

        public MyAccessModifiers(int birthYear, string idNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            this.personalInfo = personalInfo;
            IdNumber = idNumber;
        }

        public int Age
        {
            get => DateTime.Now.Year - birthYear;
        }

        protected internal bool HasLivedHalfOfLife()
        {
            return this.Age >= averageMiddleAge;
        }

        public override bool Equals(object obj)
        {
            return obj is MyAccessModifiers modifiers &&
                   personalInfo == modifiers.personalInfo &&
                   Name == modifiers.Name &&
                   Age == modifiers.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(personalInfo, Name, Age);
        }

        public static bool operator ==(MyAccessModifiers m1, MyAccessModifiers m2)
        {
            return m1.Equals(m2);
        }

        public static bool operator !=(MyAccessModifiers m1, MyAccessModifiers m2)
        {
            return !m1.Equals(m2);
        }
    }
}