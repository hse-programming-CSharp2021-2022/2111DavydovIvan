using System;

namespace Seminar
{
    class Plant
    {
        double growth = 0;
        double photosensitivity = 0;
        double frostresistance = 0;

        public Plant(double growth, double photosensitivity, double frostresistance)
        {
            this.growth = growth;
            this.photosensitivity = photosensitivity;
            this.frostresistance = frostresistance;
        }

        public double Growth { get => growth; set => growth = value; }
        public double Photosensitivity
        {
            get => photosensitivity;
            set
            {
                if (value > 0 && value < 100)
                    photosensitivity = value;
                else
                    photosensitivity = 0;
            }
        }
        public double Frostresistance
        {
            get => frostresistance;
            set
            {
                if (value > 0 && value < 100)
                    frostresistance = value;
                else
                    frostresistance = 0;
            }
        }

        public override string ToString()
        {
            return $"Растение с ростом: {Growth}, светочувствительностью: {Photosensitivity}, морозоустойчивостью: {Frostresistance}";     
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Plant[] plants = new Plant[n];
            for (int i = 0; i < plants.Length; i++)
            {
                Random random = new Random();
                Plant plant = new Plant(random.Next(25, 100), random.Next(0, 100), random.Next(0, 80));
                plants[i] = plant;

            }
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine(Environment.NewLine);

            Array.Sort(plants, delegate (Plant plant1, Plant plant2)
            {
                if (plant1.Growth < plant2.Growth)
                    return 1;
                if (plant1.Growth == plant2.Growth)
                    return 0;
                else return -1;
            });
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine(Environment.NewLine);


            Array.Sort(plants, (Plant plant1, Plant plant2) =>
            {
                if (plant1.Frostresistance > plant2.Frostresistance)
                    return 1;
                if (plant1.Frostresistance == plant2.Frostresistance)
                    return 0;
                else return -1;
            });
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine(Environment.NewLine);


            Array.Sort(plants, (Plant plant1, Plant plant2) =>
            {
                if (plant1.Photosensitivity % 2 != 0 && plant2.Photosensitivity % 2 == 0)
                    return 1;
                if (plant1.Photosensitivity == plant2.Photosensitivity)
                    return 0;
                else return -1;
            });
            Array.ForEach(plants, plant => Console.WriteLine(plant));

        }
    }
}
