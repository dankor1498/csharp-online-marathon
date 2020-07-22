using System;
using System.Collections.Generic;

namespace Sprint06
{
    internal class ShowPower
    {
        public static IEnumerable<float> FirstSuperPower(int number, int degree)
        {
            if (number == 0)
            {
                yield return 0;
                yield break;
            }
            if (degree == 0)
            {
                yield return 1;
                yield break;
            }
            if (degree < 0)
                for (int i = -1; i >= degree; i--)
                    yield return Convert.ToSingle(Math.Pow(number, i));
            else
                for (int i = 1; i <= degree; i++)
                    yield return Convert.ToSingle(Math.Pow(number, i));
        }

        public static IEnumerable<float> SuperPower(int number, int degree)
        {
            if (number == 0)
            {
                yield return 0;
                yield break;
            }
            if (degree == 0)
            {
                yield return 1;
                yield break;
            }
            int sign = degree < 0 ? -1 : 1;
            degree = degree < 0 ? -degree : degree;
            for (int i = 1; i <= degree; i++)
                yield return NewPow(number, i * sign);
        }

        public static float NewPow(int number, int degree)
        {
            if (degree == 0) return 1;
            float half = NewPow(number, degree / 2);
            if (degree % 2 == 0)
                return half * half;
            else if (degree > 0)
                return half * half * number;
            else
                return half * half / number;
        }
    }
}