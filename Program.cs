namespace Commando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commandoes solider1 = new Commandoes("aaa", "1234");
            AirCommando solider2 = new AirCommando("bbb", "5678");
            SeaCommando solider3 = new SeaCommando("ccc", "987");
            Commandoes[] arry = { solider1, solider2, solider3 };
            foreach(Commandoes solider in arry)
            {
               solider.Attack();
            }
           



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
