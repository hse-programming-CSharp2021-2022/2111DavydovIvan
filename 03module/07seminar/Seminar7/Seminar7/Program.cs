using System;
using System.Collections.Generic;

namespace Seminar7
{

    public struct Person : IComparable
    {
        private string name;
        private string lastname;
        private int age;


        public Person(string name, string lastname, string age)
        {
            this.name = name;
            this.lastname = lastname;
            int ag = int.Parse(age);
            if (ag < 0)
                throw new ArgumentOutOfRangeException("Недопустимый возраст");
            this.age = ag;
        }

        public int CompareTo(object obj)
        {
            Person person = (Person)obj;
            if (this.age > person.age)
                return 1;
            else if (this.age < person.age)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"Person {name} {lastname} с возрастом {age}";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string[] names = new string[] { "Ivan", "Vasya", "Petya", "Igor",
                "Nikolay", "Boris", "Artem"};
            string[] lastnames = new string[] { "Sidorov", "Davydov", "Chuykin",
                "Sobolev", "Budaev", "Egorov"};
            Random rnd = new Random();
            List<Person> characters = new List<Person>(n);
            for(int i = 0; i < n; i++)
            {
                characters.Add(new Person(names[rnd.Next(names.Length)],
                    lastnames[rnd.Next(lastnames.Length)], rnd.Next(1, 101).ToString()));
            }

            foreach (var person in characters) { Console.WriteLine(person); }
            Console.WriteLine("---------------------------------------");
            characters.Sort();
            foreach (var person in characters) { Console.WriteLine(person); }
            

        }
            
    }


}
