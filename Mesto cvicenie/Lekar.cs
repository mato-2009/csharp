﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_cvicenie
{
    public class Lekar
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Lekar(string name, int age)
        {
            Name = name;
            Age = age;
        }

       

        public void Liecenie()
        {
            Console.WriteLine("Meno: " + Name + " Vek: " + Age + " je Lekar/ka");


        }
    }
}

