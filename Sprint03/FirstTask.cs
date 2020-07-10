using System;

namespace Sprint03
{
    public delegate int CalcDelegate(int a, int b, char sign);

    public class CalcProgram
    {
        public static int Calc(int a, int b, char sign)
        {
            return sign switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => b == 0 ? b : a / b,
                _ => throw new ArgumentException("Неправильний код операції")
            };
        }

        public CalcDelegate funcCalc = Calc;
    }
}