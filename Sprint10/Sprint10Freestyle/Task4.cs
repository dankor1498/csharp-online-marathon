using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10Freestyle
{
    namespace Task4
    {
        public interface ILead
        {
            void CreateSubTask();
            void AssignTask();
        }

        public interface IProgrammer
        {
            void WorkOnTask();
        }

        public class TeamLead : ILead, IProgrammer
        {
            public void CreateSubTask()
            {
            }

            public void AssignTask()
            {
            }

            public void WorkOnTask()
            {
            }
        }

        public class Manager : ILead
        {
            public void CreateSubTask()
            {
            }

            public void AssignTask()
            {
            }
        }

        public class Programmer : IProgrammer
        {
            public void WorkOnTask()
            {
            }
        }
    }
}
