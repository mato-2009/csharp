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
            mesto1.VypisObcanov();
            mesto2.VypisObcanov();
        }

        



    }
}

















