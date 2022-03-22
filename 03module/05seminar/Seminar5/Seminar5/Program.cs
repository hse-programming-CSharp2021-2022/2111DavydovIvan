using System;

namespace Seminar5
{
    interface IFunction
    {
        public double Function(double x);
    }

    public delegate double Calculate(double input);

    class F : IFunction
    {
        Calculate calculate;

        public F(Calculate calculate)
        {
            this.calculate = calculate;
        }

        public double Function(double x) 
        {
            return calculate(x);
        }

    }

    class G
    {
        F first;
        F second;

        public G(F f1, F f2)
        {
            first = f1;
            second = f2;
        }

        public double GF(double x0)
        {
            return first.Function(second.Function(x0));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            G g = new G(new F(x => x * x - 4), new F(x => Math.Sin(x)));
            for (double i = 0; i < Math.PI; i += Math.PI / 16)
                Console.WriteLine(g.GF(i).ToString("F3"));
        }
    }
}
