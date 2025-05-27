using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms

namespace Commando
{
    public abstract class Commandoes
    {
        private string name;
        public string codename { get; set; }
        public static string[] tools = { "Hammer", "Chisel", "Rope", "Backpack", "Canteen" };
        public string status;
        public Commandoes(string Name, string Codename)
        {
            name = Name;
            codename = Codename;

        }
        public void Walk()
        {
            status = "Walk";
            Console.WriteLine("The soilder walk");
        }
        public void Hide()
        {
            status = "Hide";
            Console.WriteLine("The soilder hide");
        }
        public void Attack()
        {
            status = "Attack";
            Console.WriteLine($"The commando {codename} attack");
        }
        public string SayName(string commanderRank)
        {
            if(commanderRank== "GENERAL ")
            {
                return this.name;

            }
            else if(commanderRank== "COLONEL ")
            {
                return this.codename;
            }
            else
            {
                Console.WriteLine("Access denied.\n insufficient classification");
                return "Access denied, insufficient classification";
            }
        }

    }
}
