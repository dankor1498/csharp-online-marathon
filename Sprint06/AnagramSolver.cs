using System.Collections.Generic;
using System.Linq;

namespace Sprint06
{
    class AnagramSolver
    {
        public static IEnumerable<string> Permutations(IEnumerable<char> source)
        {
            int Count = source.Count();
            if (Count == 1)
                yield return new string(source.ToArray());
            else
                for (int i = 0; i < Count; i++)
                    foreach (var p in Permutations(source.Take(i).Concat(source.Skip(i + 1))))
                        yield return new string(source.Skip(i).Take(1).Concat(p).ToArray());
        }

        public static bool IsAnagram(string s1, string s2)
        {
            foreach (var s in Permutations(s1.ToArray()))
            {
                if (s2.Contains(s)) 
                    return true;
            }
            return false;
        }
    }
}
