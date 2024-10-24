using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_cvicenie
{








    public class Mesto
    {
        public string NazovMesta { get; set; }
        public List<Obcan> obcaniaList { get; set; }

        public Mesto(string NazovMesta)
        {
            this.NazovMesta = NazovMesta;
            obcaniaList = new List<Obcan>();
        }

        public void PridajObcana(Obcan obcan)
        {
            obcaniaList.Add(obcan);
        }
        public void VypisObcanov()
        {
            Console.WriteLine("Obcania mesta " + NazovMesta + ":");
            foreach (var obcan in obcaniaList)
            {
                obcan.VypisInfo();
            }

        }


    }
} 



