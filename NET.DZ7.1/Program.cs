namespace NET.DZ7._1
{
    internal class Program
    {
        struct Fraction
        {
            int numerator;
            int denominator;
            public Fraction(int c, int z)
            {
                numerator = c;
                denominator = z;
            }

            public void input()
            {
                numerator = Convert.ToInt32(Console.Read());
                denominator = Convert.ToInt32(Console.Read());
            }
            public void mult(int x)
            {
                numerator *= x;
                Console.WriteLine("Fraction:  " + numerator + "/" + denominator);
            }
            public void div(int x)
            {
                denominator *= x;
                Console.WriteLine("Fraction:  " + numerator + "/" + denominator);
            }

            public void sum(int x)
            {
                numerator += (x * denominator);
                Console.WriteLine("Fraction:  " + numerator + "/" + denominator);
            }
            public void sub(int x)
            {
                numerator -= (x * denominator);
                Console.WriteLine("Fraction:  " + numerator + "/" + denominator);

            }
            public void show()
            {
                Console.WriteLine("Fraction:  " + numerator + "/" + denominator);
            }
            public void reduct(int x)
            {
                numerator /= x;
                denominator /= x;
            }

        }


        struct ComplexNumber
        {

        }
        static void Main(string[] args)
        {
            Fraction a = new Fraction(2,3);
            a.show();
            a.sum(1);
            a.div(2);
            a.mult(3);
        }
    }
}
