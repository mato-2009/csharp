namespace Mesto_cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto mesto1 = new Mesto("Zilina");
            Mesto mesto2 = new Mesto("Praha ");
            Obcan obcan1 = new Obcan("Filip Dvere", 12);
            Obcan obcan2 = new Obcan("Martin Struhanka", 15);
            Obcan obcan3 = new Obcan("Oliver Podlaha", 25);
            Obcan obcan4 = new Obcan("Tomas Stena", 16);
            Obcan obcan5 = new Obcan("Michal Paska", 30);


            mesto1.PridajObcana(obcan5);
            mesto1.PridajObcana(obcan4);

            mesto2.PridajObcana(obcan3);
            mesto2.PridajObcana(obcan2);
            mesto2.PridajObcana(obcan1);
            

            Lekar lekar1 = new Lekar("Adam", 25);
            Lekar lekar2 = new Lekar("Filip", 35);
            Elektrikar elektrikar = new Elektrikar("Kubo", 19);
            Elektrikar elektrikar1 = new Elektrikar("Fero", 22);
            Ucitelia ucitel1 = new Ucitelia("Igor",26);
            Ucitelia ucitel2 = new Ucitelia("Michal",30);

            mesto1.PridajUcitelaDoMesta(ucitel1);
            mesto2.PridajUcitelaDoMesta(ucitel2);
            mesto1.PridajElektrikaraDeMesta(elektrikar);
            mesto2.PridajElektrikaraDeMesta(elektrikar1);
            mesto1.Pridajlekaradomesta(lekar2);
            mesto2.Pridajlekaradomesta(lekar1);


            mesto1.VypisObcanov();
            mesto2.VypisObcanov();
        }

        







        



    }
}

















