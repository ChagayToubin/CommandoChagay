namespace Commando
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            GAME game = new GAME();
            bool exit = false;

            while (!exit)
            {
               
                Console.WriteLine("1.Create Soldier\n2.Create Enemy\n3 Create Weapon\n");
              
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("creating soldier");
                        game.ADDCOMMANDO();
                        break;

                    case "2":
                        Console.WriteLine("creating enemy");
                        game.ADDENEMY();
                        break;

                    case "3":
                        Console.WriteLine("creating weapon");
                        game.ADDWEAPON();
                        break;

                    case "0":
                        Console.WriteLine("exiting");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
            
        public static void PrintRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Thread.Sleep(100);
            Console.ResetColor(); // מחזיר לצבע ברירת מחדל
        }

    }
}
