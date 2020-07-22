using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint06
{
    class ShowPowerRange
    {
        public static IEnumerable<int> PowerRanger(int degree, int start, int finish)
        {
            if (start > finish || start < 0 || finish < 0) 
            {
                yield return 0;
                yield break;
            }
            if (degree == 0)
            {
                yield return 1;
                yield break;
            }

            int Start = (int)Math.Ceiling(Math.Pow(start, 1.0 / degree));
            int Finish = (int)Math.Ceiling(Math.Pow(finish, 1.0 / degree));

            for (int i = Start; i <= Finish; i++)
                yield return (int)Math.Pow(i, degree);                      
        }
    }
}
