using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint07
{
    class Student
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public string GroupName { get; set; }
    }

    class Group
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Popularity { get; set; }
    }

}
