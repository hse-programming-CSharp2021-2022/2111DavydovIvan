using System;
using System.Linq;

namespace Seminar14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-1000, 1001);
            }
            Console.Write("Сама коллекция: ");
            foreach (var el in array) { Console.Write(el); }
            Console.WriteLine();

            var square = array.Select(x => x * x); 
            Console.Write("Коллекция квадратов: ");
            foreach (var el in square) { Console.Write(el + " "); }
            Console.WriteLine();


            var l = array.Where(x => x > 0 && x.ToString().Length > 2);
            Console.Write("Коллекция двузначных чисел: ");
            foreach (var el in l) { Console.Write(el + " ") ; }
            Console.WriteLine();

            var ord = array.Where(x => x % 2 == 0).OrderByDescending(x => x);
            Console.Write("Коллекция отсортированных четных чисел: ");
            foreach (var el in ord) { Console.Write(el + " "); }
            Console.WriteLine();

            var gr = array.Select(x => x).OrderByDescending(x => x.ToString().Length);
            Console.Write("Коллекция групп: ");
            foreach (var el in gr) { Console.Write(el + " "); }
            Console.WriteLine();
        }
    }
}
