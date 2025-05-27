using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class SeaCommando:Commandoes, InterfaceAttack
    {
        public SeaCommando(string Name, string Codename) :base(Name, Codename)
        {
          
        }
        public void Diving()
        {
            Console.WriteLine("He have the abaliti to Diving");
        }
        public override void Attack()
        {
            status = "Attack";
            Console.WriteLine($"The commando {codename} attack in the sea" );
        }
    }
}

