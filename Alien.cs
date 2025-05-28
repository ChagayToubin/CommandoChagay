using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Alien:EnemyBase
    {
        public string fromStar;
        public bool canfly;
        public Alien(double LevelDangerous, string Gender, string Religion,string Fromstar,bool Canfly):base(LevelDangerous, Gender, Religion)
        {
            fromStar = Fromstar;
            canfly = Canfly;

        }
        public override void PrintInfo()
        {
            Program.PrintRed($"Informtion :Alien\ngender :{this.gender}\nThe religion :{this.religion}\n Level danegerous:{this.levelDangerous}\nFrom star :{this.fromStar}\nFly:{this.canfly}\n--------------------------\n");
        }
    }
}
