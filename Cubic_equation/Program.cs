using System;

namespace Lab_2 //Qubic Function
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj a:");
            double a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a cannot be equal to 0");
                return;
            }
            Console.WriteLine("Podaj b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj d:");
            double d = double.Parse(Console.ReadLine());


            double w = -b / (3 * a);
            double p = ((3 * a * Math.Pow(w, 2)) + (2 * b * w) + c) / a;
            double q = ((a * Math.Pow(w, 3)) + (b * Math.Pow(w, 2)) + (c * w) + d) / a;
            double delta = Math.Pow(q, 2) / 4 + Math.Pow(p, 3) / 27;
            Console.WriteLine(delta);
            Console.WriteLine($"Delta: {delta}");

            if (delta > 0)
            {
                double u = Math.Cbrt((-q / 2) + Math.Sqrt(delta));
                Console.WriteLine(u);
                double v = Math.Cbrt((-q / 2) - Math.Sqrt(delta));
                Console.WriteLine(v);

                double x1 = u + v + w;

                double x2 = (-(u + v) / 2) + w;
                double x22 = (Math.Sqrt(3) / 2) * (u - v);

                double x3 = (-(u + v) / 2) + w;
                double x33 = (Math.Sqrt(3) / 2) * (u - v);

                Console.WriteLine("x1" + x1);
                Console.WriteLine("x2" + x2 + "+" + x22 + "i");
                Console.WriteLine("x3" + x3 + "-" + x33 + "i");
            }

            if (delta < 0)
            {
                double fi = Math.Acos(3 * q / (2 * p * -(Math.Sqrt(p / 3))));
                //double fi = 1;
                double x1 = w + (2 * Math.Sqrt(p / 3) * Math.Cos(fi / 3));
                double x2 = w + (2 * Math.Sqrt(p / 3) * Math.Cos(fi / 3 + ((2 / 3) * Math.PI)));
                double x3 = w + (2 * Math.Sqrt(p / 3) * Math.Cos(fi / 3 + ((4 / 3) * Math.PI)));

                Console.WriteLine("x1" + x1);
                Console.WriteLine("x2" + x2);
                Console.WriteLine("x3" + x3);
            }

            if (delta == 0)
            {
                double x1 = w - 2 * Math.Cbrt(q / 2);
                double x2 = w + Math.Cbrt(q / 2);

                Console.WriteLine("x1" + x1);
                Console.WriteLine("xx2" + x2);
            }


        }
    }

}