using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Enemy: EnemyBase
    {
        public string name{ get; set; }
        public double alive { get; set; }
        public bool statusAlive { get; set; }
        //public static void  Shout = shout();
       
        public Enemy(string Name, double LevelDangerous, string Gender, string Religion) :base(LevelDangerous,Gender,Religion)
        {
            name = Name;
            alive = 100;

        }
        public  void shout()
        {
            Console.WriteLine("Ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
        }
        public override void PrintInfo()
        {
          Program.PrintRed($"Informtion :umen\ngender :{this.gender}\nThe religion :{this.religion}\n Level danegerous:{this.levelDangerous}\nname:{this.name}\nLevel alive:{this.alive}\nStatus:{this.statusAlive}  ");
        }
    }
}
