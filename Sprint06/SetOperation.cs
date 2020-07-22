using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprint06
{
    class SetOperationFirst
    {
        public static List<int> Union(List<int> listA, List<int> listB) =>
            listA.Union(listB).ToList();

        public static List<int> Intersect(List<int> listA, List<int> listB) =>
            listA.Intersect(listB).ToList();

        public static List<int> LeftDifference(List<int> listA, List<int> listB) =>
            listA.Except(listB).ToList();

        public static List<int> RightDifference(List<int> listA, List<int> listB) =>
            listB.Except(listA).ToList();

        public static List<int> Addition(List<int> listA, List<int> listU) =>
            listU.Except(listA).ToList();
    }
}
