using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Sprint06
{
    public class CircleOfChildren
    {
        private int count;
        public IEnumerable<string> children { get; private set; }

        public CircleOfChildren(IEnumerable<string> children)
        {
            this.children = children;
            this.count = children.Count();
        }

        public static int[] GetPermutation(int n, int k, int pivot)
        {
            List<int> list = Enumerable.Range(0, n).ToList();
            int[] result = new int[pivot];
            int start = (k - 1) % n;

            for (int i = 0; i < pivot; i++)
            {
                result[i] = list[start];
                list.RemoveAt(start);
                if (list.Count != 0)
                    start = (start + k - 1) % list.Count;
            }

            return result;
        }

        public IEnumerable GetChildrenInOrder(int syllablesCount)
        {
            if (syllablesCount <= 0)
                yield break;

            int[] permutationChildren = GetPermutation(count, syllablesCount, count);
            for (int i = 0; i < permutationChildren.Length; i++)
                yield return children.ElementAt(permutationChildren[i]);
        }

        public IEnumerable GetChildrenInOrder(int syllablesCount, int countOfChildren)
        {
            if (syllablesCount <= 0)
                yield break;

            int[] permutationChildren;
            if (countOfChildren <= 0 || countOfChildren > count)
                permutationChildren = GetPermutation(count, syllablesCount, count);              
            else
                permutationChildren = GetPermutation(count, syllablesCount, countOfChildren);              

            for (int i = 0; i < permutationChildren.Length; i++)
                yield return children.ElementAt(permutationChildren[i]);
        }
    }

    public class OutputUtils
    {
        public static void ExitOutput(CircleOfChildren children, int syllablesCount, int countOfChildren = 0)
        {
            foreach (var item in children.GetChildrenInOrder(syllablesCount, countOfChildren))
                Console.Write(item + " ");
        }
    }
}