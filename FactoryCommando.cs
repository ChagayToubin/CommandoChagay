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
        public static void AddCommando(string name, string codename, int AirSeaNormel)
        {
            
            switch (AirSeaNormel)
            {
                case 1:
                    FactoryCommando.ListCommando.Add(new Commandoes(name, codename));
                    break;

                case 2:
                    FactoryCommando.ListCommando.Add(new AirCommando(name, codename));
                    break;
                case 3:
                    FactoryCommando.ListCommando.Add(new SeaCommando(name, codename));
                    break;
                default:
                    Console.WriteLine("-=-=-=-=-=-=-");
                    break;
            }

        }

    }
}
