using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint05
{
    class Student
    {
        public int Id { get; }
        public string Name { get; }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static HashSet<Student> GetCommonStudents(List<Student> students1, List<Student> students2) =>
            students1.Intersect(students2).ToHashSet();

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   Name == student.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
