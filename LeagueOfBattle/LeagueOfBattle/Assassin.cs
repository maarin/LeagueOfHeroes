using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfBattle
{
    public class Assassin : Hero
    {
        Random assassinRnd = new Random();

        public Assassin()
            : base()
        { 
        }

        public Assassin(int attack, int health, int arrmor)
            : base()
        {
            Attack = attack;
            Health = health;
            Arrmor = arrmor;
        }

        //Assassin has 30% chance to do special attack.
        //We create one random variable between 0-100
        //if variable <=30 assassin do special damage
        //if not, he do a normal attack.
        public override int SpecialAttack()
        {
            if (assassinRnd.Next(0, 100) <= 30)
            {
                return (Attack * 300) / 100;
            }
            else
            {
                return DoDamage();
            }
        }

        //Assassin hasn't Special block and we return a "Block" method.
        public override int SpecialBlock()
        {
            return Block();
        }
    }
}
