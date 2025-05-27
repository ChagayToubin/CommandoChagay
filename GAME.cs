using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class GAME
    {
        public void ADDWEAPON()
        {
            FactoryWeapon.AddWeapon();
        }
        public void ADDCOMMANDO()
        {
            FactoryCommando.AddCommando();
        }
        public void ADDENEMY()
        {
            EnemyFactory.AddEnmy();
        }
    }
}
