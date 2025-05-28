using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class EnemyFactory
    {
        public static List<EnemyBase> ListEnmy = new List<EnemyBase>();
        public static void AddEnmy()
        {
            Console.WriteLine("which Enmy do u want to creat press 1 for alien 2 for normal umen");
            string input = Console.ReadLine();
            switch (input)
            {
                case "2":
                    ListEnmy.Add(new Enemy("Khaled Fadi", 4.7, "Male", "Islam"));
                    break;
                case "1":
                    ListEnmy.Add(new Alien(9.3, "Unknown", "None", "Zebulon-5", true));
                    break;
                default:
                    AddEnmy();
                    break;
            }
            ListEnmy.Last().PrintInfo();
        }
    }
}
