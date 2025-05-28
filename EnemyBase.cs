using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public abstract class EnemyBase
    {
        public double levelDangerous;
        public string gender;
        public string religion;
        public EnemyBase(double LevelDangerous,string Gender,string Religion)
        {
            levelDangerous = LevelDangerous;
            gender = Gender;
            religion = Religion;
        }
        public abstract  void PrintInfo();
       
    }
}
