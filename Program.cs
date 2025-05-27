namespace Commando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GAME game = new GAME();
            game.ADDCOMMANDO();
            Console.WriteLine($"--------{FactoryCommando.ListCommando[0].codename}-----------------");

            game.ADDENEMY();
            Console.WriteLine($"-------{EnemyFactory.ListEnmy[0].alive}---{EnemyFactory.ListEnmy[0].name}");

            game.ADDWEAPON();
            Console.WriteLine($"=-=-={FactoryWeapon.ListWeapon[0].Color}-----{FactoryWeapon.ListWeapon[0].Weight}----{FactoryWeapon.ListWeapon[0].Name}");
        }
       
    }
}
