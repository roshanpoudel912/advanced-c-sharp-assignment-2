﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool IsAdult() => Age >= 18;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


    }
}
