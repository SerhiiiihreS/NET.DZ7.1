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

        struct Birthday
        {
            public int year;
            public int month;
            public int date;
            public Birthday(int year, int month, int date)
            {
                this.year = year;
                this.month = month;
                this.date = date;
            }
            public void Input()
            {
                year = Convert.ToInt32(Console.Read());
                month = Convert.ToInt32(Console.Read());
                date = Convert.ToInt32(Console.Read());
            }
            public void Output()
            {
                Console.WriteLine("year ->" + year);
                Console.WriteLine("month ->" + month);
                Console.WriteLine("date ->" + date);
            }
            public void Determine()
            {
                int Kmonth;
                if (year % 4 == 0 || year % 100 == 0 && year % 400 == 0)
                {
                    switch (month)
                    {
                        case 1:
                            Kmonth = 0;
                            break;
                        case 2:
                            Kmonth = 3;
                            break;
                        case 3:
                            Kmonth = 4;
                            break;
                        case 4:
                            Kmonth = 0;
                            break;
                        case 5:
                            Kmonth = 2;
                            break;
                        case 6:
                            Kmonth = 5;
                            break;
                        case 7:
                            Kmonth = 0;
                            break;
                        case 8:
                            Kmonth = 3;
                            break;
                        case 9:
                            Kmonth = 6;
                            break;
                        case 10:
                            Kmonth = 1;
                            break;
                        case 11:
                            Kmonth = 4;
                            break;
                        case 12:
                            Kmonth = 6;
                            break;
                        default:
                            Kmonth = 0;
                            break;

                    }
                }
                else
                {
                    switch (month)
                    {
                        case 1:
                            Kmonth = 1;
                            break;
                        case 2:
                            Kmonth = 4;
                            break;
                        case 3:
                            Kmonth = 4;
                            break;
                        case 4:
                            Kmonth = 0;
                            break;
                        case 5:
                            Kmonth = 2;
                            break;
                        case 6:
                            Kmonth = 5;
                            break;
                        case 7:
                            Kmonth = 0;
                            break;
                        case 8:
                            Kmonth = 3;
                            break;
                        case 9:
                            Kmonth = 6;
                            break;
                        case 10:
                            Kmonth = 1;
                            break;
                        case 11:
                            Kmonth = 4;
                            break;
                        case 12:
                            Kmonth = 6;
                            break;
                        default:
                            Kmonth = 0;
                            break;

                    }

                }

                int Kyear;
                int CkYr;
                if (1699 > year && year > 1599) { CkYr = 6; }
                else if (year < 1799 && year > 1699) { CkYr = 4; }
                else if (year < 1899 && year > 1799) { CkYr = 2; }
                else if (year < 1999 && year > 1899) { CkYr = 0; }
                else if (year < 2099 && year > 1999) { CkYr = 6; }
                else { CkYr = 4; }
                Kyear = (CkYr + year % 100 + year % 100 / 4) % 7;
                int DayWek = (date + Kmonth + Kyear) % 7;

                switch (DayWek)
                {
                    case 0:
                        Console.WriteLine("The person was born - Saturday");
                        break;
                    case 1:
                        Console.WriteLine("The person was born - Sunday");
                        break;
                    case 2:
                        Console.WriteLine("The person was born - Monday");
                        break;
                    case 3:
                        Console.WriteLine("The person was born - Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("The person was born - Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("The person was born - Thursday");
                        break;
                    case 6:
                        Console.WriteLine("The person was born - Friday");
                        break;
                }
            }
            public void DetermineWillBe(int Nyear)
            {
                int Kmonth;
                if (Nyear % 4 == 0 || Nyear % 100 == 0 && Nyear % 400 == 0)
                {
                    switch (month)
                    {
                        case 1:
                            Kmonth = 0;
                            break;
                        case 2:
                            Kmonth = 3;
                            break;
                        case 3:
                            Kmonth = 4;
                            break;
                        case 4:
                            Kmonth = 0;
                            break;
                        case 5:
                            Kmonth = 2;
                            break;
                        case 6:
                            Kmonth = 5;
                            break;
                        case 7:
                            Kmonth = 0;
                            break;
                        case 8:
                            Kmonth = 3;
                            break;
                        case 9:
                            Kmonth = 6;
                            break;
                        case 10:
                            Kmonth = 1;
                            break;
                        case 11:
                            Kmonth = 4;
                            break;
                        case 12:
                            Kmonth = 6;
                            break;
                        default:
                            Kmonth = 0;
                            break;

                    }
                }
                else
                {
                    switch (month)
                    {
                        case 1:
                            Kmonth = 1;
                            break;
                        case 2:
                            Kmonth = 4;
                            break;
                        case 3:
                            Kmonth = 4;
                            break;
                        case 4:
                            Kmonth = 0;
                            break;
                        case 5:
                            Kmonth = 2;
                            break;
                        case 6:
                            Kmonth = 5;
                            break;
                        case 7:
                            Kmonth = 0;
                            break;
                        case 8:
                            Kmonth = 3;
                            break;
                        case 9:
                            Kmonth = 6;
                            break;
                        case 10:
                            Kmonth = 1;
                            break;
                        case 11:
                            Kmonth = 4;
                            break;
                        case 12:
                            Kmonth = 6;
                            break;
                        default:
                            Kmonth = 0;
                            break;

                    }

                }

                int Kyear;
                int CkYr;
                if (1699 > Nyear && Nyear > 1599) { CkYr = 6; }
                else if (Nyear < 1799 && Nyear > 1699) { CkYr = 4; }
                else if (Nyear < 1899 && Nyear > 1799) { CkYr = 2; }
                else if (Nyear < 1999 && Nyear > 1899) { CkYr = 0; }
                else if (Nyear < 2099 && Nyear > 1999) { CkYr = 6; }
                else { CkYr = 4; }
                Kyear = (CkYr + Nyear % 100 + Nyear % 100 / 4) % 7;
                int DayWek = (date + Kmonth + Kyear) % 7;

                switch (DayWek)
                {
                    case 0:
                        Console.WriteLine("The person was born - Saturday");
                        break;
                    case 1:
                        Console.WriteLine("The person was born - Sunday");
                        break;
                    case 2:
                        Console.WriteLine("The person was born - Monday");
                        break;
                    case 3:
                        Console.WriteLine("The person was born - Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("The person was born - Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("The person was born - Thursday");
                        break;
                    case 6:
                        Console.WriteLine("The person was born - Friday");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Fraction a = new Fraction(2,3);
            a.show();
            a.sum(1);
            a.div(2);
            a.mult(3);
            Console.WriteLine();


            Console.WriteLine();
            Birthday Anj = new Birthday(12,3,2012);
            Anj.Determine();
            Console.WriteLine();
            Anj.DetermineWillBe(2024);
        }
    }
}
