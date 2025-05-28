using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Stone : BaseWeapon
    {
        public bool status;//שלם או שבור
        public int quantitydurability;//כמה פעמים ניתן לשימוש
        public Stone(string name, string color, double weight, bool Status, int Quantitydurability) : base(name, color, weight)
        {
            status = Status;
            quantitydurability = Quantitydurability;
        }

        public override void PrintInfo()
        {
            Program.PrintRed($"Weapon Info:\nName: {Name}\nColor: {Color}\nWeight: {Weight}\nStatus: {(status ? "Intact" : "Broken")}\nRemaining Hits: {quantitydurability}\n------------------------\n");
        }

    }
}
