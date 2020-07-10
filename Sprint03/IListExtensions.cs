using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint03
{
    public static class IListExtensions
    {
        public static void IncreaseWith(this IList<int> list, int number)
        {
            for (int i = 0; i < list.Count(); i++)
                list[i] += number;
        }            
    }

    public static class IEnumerableExtensions
    {
        public static string ToString<T>(this IEnumerable<T> list)
        {
            int Count = list.Count();
            StringBuilder str = new StringBuilder("[", Count);
            for (int i = 0; i < Count - 1; i++)
                str.Append(list.ElementAt(i) + ", ");
            return str.Append(list.ElementAt(Count - 1) + "]").ToString();
        }
    }
}
