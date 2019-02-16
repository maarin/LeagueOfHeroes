using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace LeagueOfBattle
{
    public class GameEngine
    {
        //Select Hero.-----------------------------------------------------------------------------
        //Use this variable to check left or right hero we pick.
        public bool isSelectHero;

        //Use this variables in "BtnStart", if they are false we can't start the battle phase.
        public bool isLockLeftHero;
        public bool isLockRightHero;

        //Use this variables to get which hero we choose.
        public static bool selectLeftWarrior;
        public static bool selectLeftKnight;
        public static bool selectLeftAssassin;
        public static bool selectLeftMage;
        public static bool selectLeftMarksman;
        public static bool selectRightWarrior;
        public static bool selectRightKnight;
        public static bool selectRightAssassin;
        public static bool selectRightMage;
        public static bool selectRightMarksman;

        public bool IsSelectHero { get; set; }

        public bool IsLockLeftHero { get; set; }
        public bool IsLockRightHero { get; set; }

        public static bool SelectLeftWarrior { get; set; }
        public static bool SelectLeftKnight { get; set; }
        public static bool SelectLeftAssassin { get; set; }
        public static bool SelectLeftMage { get; set; }
        public static bool SelectLeftMarksman { get; set; }
        public static bool SelectRightWarrior { get; set; }
        public static bool SelectRightKnight { get; set; }
        public static bool SelectRightAssassin { get; set; }
        public static bool SelectRightMage { get; set; }
        public static bool SelectRightMarksman { get; set; }

        //Battle.--------------------------------------------------------------------------
        //Use this two variables to return Block inf and Takan damage info in label.
        public int infoLabelBlock;
        public int infoLabelDamageTaken;

        //Use this variable to check is hero dead.
        public bool dead;

        public int InfoLabelBlock { get; set; }
        public int InfoLabelDamageTaken { get; set; }

        public bool Dead { get; set;}

        //Hero do attack 
        //we take attack value hero whos declare attack
        // and take cuurent helth and arrmor value hero whos deffend
        public int DoAttack(int attack, int currHealth, int arrmor)
        {
            //Give value on InfoLabelBlock and return in label info.
            InfoLabelBlock = arrmor;

            //Give value on InfoLabelDamageTaken and return in label info.
            InfoLabelDamageTaken = attack;

            //Calculate the attack.
            currHealth = (currHealth + arrmor) - attack;

            //If current health < 0
            //we give it value = 0, because health cant'be negative
            if (currHealth < 0)
            {
                currHealth = 0;
            }

            return currHealth;
        }

        //Check if current health = 0 return dead = true and game and.
        public bool isDead(int currHealth)
        {
            if (currHealth <= 0)
            {
                return Dead = true;
            }
            else
            {
                return Dead = false;
            }
        }
    }
}
