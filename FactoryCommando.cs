using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class FactoryCommando
    {
        public static List<Commandoes> ListCommando = new List<Commandoes>();
        public static void AddCommando()
        {
            Console.WriteLine("enter number betwin 1-3 to create new solider 1 for sea 2 for Air ");
            int AirSeaNormel = int.Parse(Console.ReadLine());



            switch (AirSeaNormel)
            {
               

                case 2:
                    FactoryCommando.ListCommando.Add(new AirCommando("Noam Cohen", "123"));
                    break;

                case 1:
                    FactoryCommando.ListCommando.Add(new SeaCommando("Avi Rahamim", "444"));
                    break;

                default:
                    Console.WriteLine("-=-=-=-=-=-=-");
                    break;
            }
            ListCommando.Last().PrintInfo();

        }

    }
}
