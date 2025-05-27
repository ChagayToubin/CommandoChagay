using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class EnemyFactory
    {
        public List<Enemy> ListEnmy = new List<Enemy>();
        public void AddEnmy(string name)
        {
            ListEnmy.Add(new Enemy(name));

        }
    }
}
