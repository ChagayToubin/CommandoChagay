using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Enemy
    {
        public string name{ get; set; }
        public double alive { get; set; }
        public bool statusAlive { get; set; }
        //public static void  Shout = shout();
       
        public Enemy(string Name)
        {
            name = Name;
            alive = 100;

        }
        public  void shout()
        {
            Console.WriteLine("Ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
        }
    }
}
