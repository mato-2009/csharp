using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mesto_cvicenie
{
    public class Ucitelia
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Ucitelia(string name, int age)
        {
            Name = name;
            Age = age;
        }



        public void ucenie()
        {
            Console.WriteLine("Meno: " + Name + " Vek: " + Age + " je ucitel/ka");


        }
    }
}

