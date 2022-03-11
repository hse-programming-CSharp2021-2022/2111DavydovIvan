using System;
using System.Collections.Generic;
using System.IO;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Numbers.bin";

            Random rnd = new Random();
            using(BinaryWriter binaryWriter = new(File.Open(path, FileMode.Create)))
            {
                for(int i = 0; i < 10; i++)
                {
                    binaryWriter.Write(rnd.Next(1, 101));
                }
            }

            List<int> list = new List<int>();

            using(BinaryReader binaryReader = new(File.Open(path, FileMode.Open)))
            {
                for(int i = 0; i < 10; i++)
                {
                    list.Add(binaryReader.ReadInt32());
                }
            }
            foreach (var el in list) { Console.WriteLine(el); }

            int num = int.Parse(Console.ReadLine());
            int ind = 0;
            int m = 101;

            for(int i = 0; i < 10; i++)
            {
                if(m > Math.Abs(list[i] - num))
                {
                    m = Math.Abs(list[i] - num);
                    ind = i;
                }
            }
            list[ind] = num;

            using(BinaryWriter binary = new(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach(var el in list) { binary.Write(el); }
            }

            using (BinaryReader binary = new(File.Open(path, FileMode.OpenOrCreate)))
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine(binary.ReadInt32() + " ");
                }
            }
        }
    }
}
