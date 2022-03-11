using System;
using System.Collections.Generic;

namespace Departament
{
    [Serializable]
    public class University
    {
        public List<Department> Departments = new List<Department>();

        public University(List<Department> departaments)
        {
            Departments = departaments;
        }
    }
}
