using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Departament
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new("Vasya");
            Human human2 = new("Ivan");
            Human human3 = new("Dmitriy");
            Professor professor1 = new("Chuykin");
            Professor professor2 = new("Smirnov");

            List<Human> list = new List<Human> { human1, human2, human3,
                                    professor1, professor2};
            List<Human> list2 = new List<Human> { human1, human3, professor1};
            List<Human> list3 = new List<Human> { human3, professor1, professor2 };
            List<Human> list4 = new List<Human> { human2, human3, professor2 };

            Department department1 = new Department(list2);
            Department department2 = new Department(list);
            Department department3 = new Department(list3);
            Department department4 = new Department(list4);

            List<Department> departments1 = new List<Department> { department1, department2 };
            List<Department> departments2 = new List<Department> { department3, department4 };

            University university1 = new University(departments1);
            University university2 = new University(departments2);

            University[] universities = new University[] { university1, university2};

            BinaryFormatter binaryformatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("University.bin", FileMode.Create))
            {
                binaryformatter.Serialize(stream, universities);
            }

            XmlSerializer xml = new XmlSerializer(typeof(University));
            using (FileStream stream = new FileStream("University.xml", FileMode.Create))
            {
                xml.Serialize(stream, universities);
            }

            string jsonString = JsonSerializer.Serialize(universities);
            FileStream file = new FileStream("University.json", FileMode.Create);
            using (StreamWriter stream = new StreamWriter(file))
            {
                stream.Write(jsonString);
            }
            file.Close();
        }
    }
}
