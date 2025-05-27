using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class EnemyFactory
    {
        public static List<Enemy> ListEnmy = new List<Enemy>();
        public static void AddEnmy()
        {
            Console.WriteLine("Enter a name to new enemy");
            EnemyFactory.ListEnmy.Add(new (Console.ReadLine()));

        }
    }
}
