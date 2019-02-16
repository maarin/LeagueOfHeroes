using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfBattle
{
    public enum HeroClasses { Warrior, Knight, Assassin, Mage, Marksman, Unknown}

    public abstract class Hero
    {
        Random rnd = new Random();

        protected HeroClasses heroClass;
        protected int attack;
        protected int health;
        protected int arrmor;
        protected int currHealth;
        

        public HeroClasses HeroClass { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Arrmor { get; set; }
        public int CurrHealth { get; set; }
        

        public Hero()
        {
           // HeroClass = HeroClasses.Unknown; 
            Attack = 0;
            Health = 0;
            Arrmor = 0;
        }

        //Every hero do between 80 - 120% damage from their attack point. 
        public int DoDamage()
        {
           return (Attack * rnd.Next(80, 120)) / 100;
        }

        //Every hero can block between 80 - 120% from their arrmor point;
        public int Block()
        {
            return (Arrmor * rnd.Next(80, 120)) / 100;
        }

        //Create absrtract method for special attack.
        //Every hero has different attack.
        public abstract int SpecialAttack();

        //Create abstarct method for special block.
        //Some hero has a special block.
        public abstract int SpecialBlock();
    }
}
