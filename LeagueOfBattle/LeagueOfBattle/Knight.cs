using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfBattle
{
   public class Knight : Hero
    {
       Random knightRnd = new Random();

        public Knight()
            : base()
        { 
        }

        public Knight(int attack, int health, int arrmor)
            : base()
        {
            Attack = attack;
            Health = health;
            Arrmor = arrmor;
        }

        //Knight has 20% chance to do special attack.
        //We create one random variable between 0-100
        //if variable <=20 knight do special damage
        //if not, he do a normal attack.
        public override int SpecialAttack()
        {
            if (knightRnd.Next(0, 100) <= 20)
            {
                return (Attack * 200) / 100;
            }
            else
            {
                return DoDamage();
            }
        }

        //Knight has 10% chance to do special block.
        //We create one random variable between 0-100
        //if variable <=10 knight do special block
        //if not, he do a normal block.
        public override int SpecialBlock()
        {
            if (knightRnd.Next(0, 100) <= 10)
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
