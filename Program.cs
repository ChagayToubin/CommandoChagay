namespace Commando
{
    internal class Program
    {
        static void Main(string[] args)
        {
           



            //check();
        }
        public static void check()
        {
            Commandoes Solider = new Commandoes("chagay","123456");
            Console.WriteLine(Solider.codename + "  " + Solider.SayName("as"));

            SeaCommando a = new SeaCommando("a", "as");
            Console.WriteLine(a.codename);

            Weapon weapon = new Weapon("Handgun", "Rafael", 100);
            Console.WriteLine(weapon.name + " " + weapon.manufacturer + " " + weapon.numberbullets);
        }
    }
}
