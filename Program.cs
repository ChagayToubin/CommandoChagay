namespace Commando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Commandoes Solider = new Commandoes("chagay", "123456");
            Console.WriteLine(Solider.codename);
            Solider.codename = "21";

            Console.WriteLine(Solider.codename);
            
            //check();
        }
        public static void check()
        {
            Commandoes Solider = new Commandoes("chagay", "123456");
            Console.WriteLine(Solider.codename + "  " + Solider.SayName("as"));

            Weapon weapon = new Weapon("Handgun", "Rafael", 100);
            Console.WriteLine(weapon.name + " " + weapon.manufacturer + " " + weapon.numberbullets);
        }
    }
}
