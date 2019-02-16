using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfBattle
{
    public class Mage : Hero
    {
        Random mageRnd = new Random();

        public Mage()
            : base()
        { 
        }

        public Mage(int attack, int health, int arrmor)
            : base()
        { 
            Attack = attack;
            Health = health;
            Arrmor = arrmor;
        }

        //Mage hasn't special attack and we return "DoDamage" method.
        public override int SpecialAttack()
        {
            return DoDamage();
        }

        //Mage has 30% chance to do special block.
        //We create one random variable between 0-100
        //if variable <=30 mage do special block
        //if not, he do a normal block.
        public override int SpecialBlock()
        {
            if (mageRnd.Next(0, 100) <= 30)
            {

                return DoDamage();
            }
            else
            {
                return Block();
            }
        }
    }
}
