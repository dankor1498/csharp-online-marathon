using System;

namespace Sprint01
{
    class Fraction
    {
        private readonly int numerator, denominator;
        public int GCD { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.GCD = GetGCD(numerator, denominator);
        }

        private static int GetGCD(int a, int b)
        {            
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a > 0 ? a : -a;
        }

        public static Fraction operator +(Fraction fraction)
        {
            return new Fraction(fraction.numerator / fraction.GCD, fraction.denominator / fraction.GCD);
        }

        public static Fraction operator -(Fraction fraction)
        {
            return new Fraction(-(fraction.numerator / fraction.GCD), fraction.denominator / fraction.GCD);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return +(new Fraction(f1.numerator * f2.denominator + f2.numerator * f1.denominator,
                f1.denominator * f2.denominator));  
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return +(new Fraction(f1.numerator * f2.denominator - f2.numerator * f1.denominator,
                f1.denominator * f2.denominator));
        }

        public static Fraction operator ~(Fraction fraction)
        {
            return new Fraction(fraction.denominator / fraction.GCD, fraction.numerator / fraction.GCD);
        }

        public static Fraction operator !(Fraction fraction)
        {
            return new Fraction(fraction.denominator / fraction.GCD, fraction.numerator / fraction.GCD);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.numerator / f1.GCD == f2.numerator / f2.GCD &&
                f1.denominator / f1.GCD == f2.denominator / f2.GCD;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return f1.numerator / f1.GCD != f2.numerator / f2.GCD &&
                f1.denominator / f1.GCD != f2.denominator / f2.GCD;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return +(new Fraction(f1.numerator * f2.numerator, f1.denominator * f2.denominator));
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return f1 * !f2;
        }

        public override string ToString()
        {
            if(numerator < 0 && denominator < 0)
            {
                return $"{-numerator / GCD} / {-denominator / GCD}";
            }
            if(denominator < 0)
            {
                return $"-{numerator / GCD} / {-denominator / GCD}";
            }
            return $"{numerator / GCD} / {denominator / GCD}";
        }

        public override bool Equals(object obj)
        {
            return obj is Fraction fraction &&
                   numerator == fraction.numerator &&
                   denominator == fraction.denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }
    }
}