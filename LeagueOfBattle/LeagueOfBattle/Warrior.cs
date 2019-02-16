using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfBattle
{
    public class Warrior : Hero
    {
        Random warriorRnd = new Random();

        public Warrior()
            : base()
        { 
        }

        public Warrior(int attack, int health, int arrmor)
            : base()
        {
            //HeroClass = heroClass; 
            Attack = attack;
            Health = health;
            Arrmor = arrmor;
        }

        //Warrior hasn't Special attack and we return a "DoDamage" method.
        public override int SpecialAttack()
        {
               return DoDamage();
        }

        //Warrior hasn't Special block and we return a "Block" method.
        public override int SpecialBlock()
        {
            return Block();
        }
    }
}
