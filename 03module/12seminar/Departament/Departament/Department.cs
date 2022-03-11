using System;
using System.Collections.Generic;

namespace Departament
{
    [Serializable]
    public class Department
    {
        public List<Human> People = new List<Human>();
        public Department(List<Human> people)
        {
            People = people;
        }
    }
}
