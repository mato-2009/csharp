namespace Cvicenie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player KladnaPostava = new Player("Knight", 10, 100, 50);

            Player ZapornaPostava = new Player("MegaKnight", 10, 100, 50);


            Console.WriteLine("Zaporna postava HP:" + ZapornaPostava.HP);
            KladnaPostava.DamagePlayer(ZapornaPostava);
            Console.WriteLine("Zaporna postava HP:" + ZapornaPostava.HP);


            while (true)
            {
            if (ZapornaPostava.HP <= 0) 
            {

                    Console.WriteLine("kladna postava vyhrala");
                    break;
                
                }

            if(KladnaPostava.HP <= 0)
                {
                    Console.WriteLine("Zaporna postava prehrala");
                }
                break; 

            }
            
            
            
                           
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
} 











