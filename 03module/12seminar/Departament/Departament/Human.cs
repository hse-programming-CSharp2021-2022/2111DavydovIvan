﻿using System;
namespace Departament
{
    [Serializable]
    public class Human
    {
        public string Name { get; set; }
        public Human(string name)
        {
            Name = name;
        }
    }
}
