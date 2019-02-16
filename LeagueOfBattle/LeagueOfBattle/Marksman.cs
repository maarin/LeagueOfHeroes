using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfBattle
{
    public class Marksman : Hero
    {
        Random marksmanRnd = new Random();

        public Marksman()
            : base()
        { 
        }

        public Marksman(int attack, int health, int arrmor)
            : base()
        {
            Attack = attack;
            Health = health;
            Arrmor = arrmor;
        }

        //Marksman has 30% chance to do special attack.
        //We create one random variable between 0-100
        //if variable <=30 marksman do normal damage
        //and heal himself with half from his damage
        //if not, he do a normal attack.
        public override int SpecialAttack()
        {
            if (marksmanRnd.Next(0, 100) <= 30)
            {
                CurrHealth += (Attack / 2);
                return DoDamage();
            }
            else
            {
                return DoDamage();
            }
        }

        //Marksman hasn't Special block and we return a "Block" method.
        public override int SpecialBlock()
        {
            return Block();
        }
    }
}
