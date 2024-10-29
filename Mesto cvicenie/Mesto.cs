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
        public List<Obcan> obcania { get; set; }
        public List<Lekar> lekari { get; set; }
        public List<Ucitelia> ucitelia { get; set; }
        public List<Elektrikar> elektrikari { get; set; }
        public Mesto(string nazovMesta)
        {
            NazovMesta = nazovMesta;
            obcania = new List<Obcan>();
            lekari = new List<Lekar>();
            ucitelia = new List<Ucitelia>();
            elektrikari = new List<Elektrikar>();
        }
        public void PridajElektrikaraDeMesta(Elektrikar elektrikar)
        {
            elektrikari.Add(elektrikar);
        }
        public void PridajUcitelaDoMesta(Ucitelia ucitel)
        {
            ucitelia.Add(ucitel);
        }


        public void Pridajlekaradomesta(Lekar lekar)
        {
            lekari.Add(lekar);
        }


        public void PridajObcana(Obcan obcan)
        {
            obcania.Add(obcan);
        }
        public void VypisObcanov()
        {
            Console.WriteLine("Obcania mesta " + NazovMesta);
            foreach (var obcan in obcania)
            {
                obcan.VypisInfo();
            }
            Console.WriteLine("\n");
            foreach (var lekar in lekari)
            {
                lekar.Liecenie();
            }
            Console.WriteLine("\n");
            foreach (var ucitel in ucitelia)
            {
                ucitel.ucenie();
            }
            Console.WriteLine("\n");
            foreach (var elektrikar in elektrikari)
            {
                elektrikar.kabel();
            }
            Console.WriteLine("\n");

        }
    }
} 

