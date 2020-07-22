using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sprint06
{
    class PalindromeSolver
    {        
        public static bool IsPalindrome(IEnumerable<char> number)
        {
            int Count = number.Count();
            for (int i = 0, j = Count - 1; i < Count / 2; i++, j--)
            {
                if(number.ElementAt(i) != number.ElementAt(j))
                    return false;
            }
            return true;
        }

        public static string GetHeritor(IEnumerable<char> number)
        {
            int Count = number.Count();
            if (Count == 2) 
                return new string(number.ToArray());

            int a, b;
            if (Count == 3)
            {
                a = (int)Char.GetNumericValue(number.ElementAt(0));
                b = (int)Char.GetNumericValue(number.ElementAt(1));
                return a + b + number.ElementAt(2).ToString();
            }
            
            StringBuilder next = new StringBuilder(Count);

            for (int i = 0; i < Count; i++)
            {
                a = (int)Char.GetNumericValue(number.ElementAt(i));
                b = (int)Char.GetNumericValue(number.ElementAt(++i));
                next.Append(a + b).ToString();                    
            }

            return next.ToString();
        }

        public static bool IsPalindromeHeritor(long number)
        {
            char[] numberArray = number.ToString().ToCharArray();
            while (numberArray.Length != 2)
            {
                if (IsPalindrome(numberArray))
                    return true;
                numberArray = GetHeritor(numberArray).ToCharArray();
            }
            return numberArray[0] == numberArray[1];
        }
    }
}
