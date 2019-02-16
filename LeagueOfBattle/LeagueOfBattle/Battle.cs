using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueOfBattle
{
    public partial class Battle : Form
    {
        Hero leftHero;
        Hero rightHero;

        GameEngine battle = new GameEngine();

        public Battle()
        {
            InitializeComponent();
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            //Check who is selected hero and initialization it.
            if (GameEngine.SelectLeftWarrior)
            {
                leftHero = new Warrior(69, 616, 35);
                leftHero.CurrHealth = leftHero.Health;
                PicBoxLeftHeroBattle.Image = Properties.Resources.LeftWarrior;
                LblLeftHealth.Text = "Heatlth: " + leftHero.Health + "/" + leftHero.CurrHealth;
                LblLeftAttack.Text = "Attack: " + leftHero.Attack;
                LblLeftArrmor.Text = "Arrmor: " + leftHero.Arrmor;
            }
            else if (GameEngine.SelectLeftKnight)
            {
                leftHero = new Knight(66, 597, 36);
                leftHero.CurrHealth = leftHero.Health;
                PicBoxLeftHeroBattle.Image = Properties.Resources.LeftKnight;
                LblLeftHealth.Text = "Heatlth: " + leftHero.Health + "/" + leftHero.CurrHealth;
                LblLeftAttack.Text = "Attack: " + leftHero.Attack;
                LblLeftArrmor.Text = "Arrmor: " + leftHero.Arrmor;
            }
            else if (GameEngine.SelectLeftAssassin)
            {
                leftHero = new Assassin(61, 515, 21);
                leftHero.CurrHealth = leftHero.Health;
                PicBoxLeftHeroBattle.Image = Properties.Resources.LeftAssassin;
                LblLeftHealth.Text = "Heatlth: " + leftHero.Health + "/" + leftHero.CurrHealth;
                LblLeftAttack.Text = "Attack: " + leftHero.Attack;
                LblLeftArrmor.Text = "Arrmor: " + leftHero.Arrmor;
            }
            else if (GameEngine.SelectLeftMage)
            {
                leftHero = new Mage(63, 570, 28);
                leftHero.CurrHealth = leftHero.Health;
                PicBoxLeftHeroBattle.Image = Properties.Resources.LeftMage;
                LblLeftHealth.Text = "Heatlth: " + leftHero.Health + "/" + leftHero.CurrHealth;
                LblLeftAttack.Text = "Attack: " + leftHero.Attack;
                LblLeftArrmor.Text = "Arrmor: " + leftHero.Arrmor;
            }
            else
            {
                leftHero = new Marksman(66, 498, 28);
                leftHero.CurrHealth = leftHero.Health;
                PicBoxLeftHeroBattle.Image = Properties.Resources.LeftMarksman;
                LblLeftHealth.Text = "Health: " + leftHero.Health + "/" + leftHero.CurrHealth;
                LblLeftAttack.Text = "Attack: " + leftHero.Attack;
                LblLeftArrmor.Text = "Arrmor: " + leftHero.Arrmor;
            }

            //Check who is selected hero and initialization it.------------------------------------------------
            if (GameEngine.SelectRightWarrior)
            {
                rightHero = new Warrior(69, 616, 35);
                rightHero.CurrHealth = rightHero.Health;
                PicBoxRightHeroBattle.Image = Properties.Resources.RightWarrior;
                LblRightHealth.Text = "Heatlth: " + rightHero.Health + "/" + rightHero.CurrHealth;
                LblRightAttack.Text = "Attack: " + rightHero.Attack;
                LblRightArrmor.Text = "Arrmor: " + rightHero.Arrmor;
            }
            else if (GameEngine.SelectRightKnight)
            {
                rightHero = new Knight(66, 597, 36);
                rightHero.CurrHealth = rightHero.Health;
                PicBoxRightHeroBattle.Image = Properties.Resources.RightKnight;
                LblRightHealth.Text = "Heatlth: " + rightHero.Health + "/" + rightHero.CurrHealth;
                LblRightAttack.Text = "Attack: " + rightHero.Attack;
                LblRightArrmor.Text = "Arrmor: " + rightHero.Arrmor;
            }
            else if (GameEngine.SelectRightAssassin)
            {
                rightHero = new Assassin(61, 515, 21);
                rightHero.CurrHealth = rightHero.Health;
                PicBoxRightHeroBattle.Image = Properties.Resources.RightAssassin;
                LblRightHealth.Text = "Heatlth: " + rightHero.Health + "/" + rightHero.CurrHealth;
                LblRightAttack.Text = "Attack: " + rightHero.Attack;
                LblRightArrmor.Text = "Arrmor: " + rightHero.Arrmor;
            }
            else if (GameEngine.SelectRightMage)
            {
                rightHero = new Mage(63, 570, 28);
                rightHero.CurrHealth = rightHero.Health;
                PicBoxRightHeroBattle.Image = Properties.Resources.RightMage;
                LblRightHealth.Text = "Heatlth: " + rightHero.Health + "/" + rightHero.CurrHealth;
                LblRightAttack.Text = "Attack: " + rightHero.Attack;
                LblRightArrmor.Text = "Arrmor: " + rightHero.Arrmor;
            }
            else
            {
                rightHero = new Marksman(66, 498, 28);
                rightHero.CurrHealth = rightHero.Health;
                PicBoxRightHeroBattle.Image = Properties.Resources.RightMarksman;
                LblRightHealth.Text = "Health: " + rightHero.Health + "/" + rightHero.CurrHealth;
                LblRightAttack.Text = "Attack: " + rightHero.Attack;
                LblRightArrmor.Text = "Arrmor: " + rightHero.Arrmor;
            }
        }

        private void BtnFight_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //When timer start we start the battle.
            //Use "DoAttack" method first attack left hero.
            rightHero.CurrHealth = battle.DoAttack(leftHero.SpecialAttack(), rightHero.CurrHealth, rightHero.SpecialBlock());
            //Every time after attack we return the current health.
            LblRightHealth.Text = "Heatlth: " + rightHero.Health + "/" + rightHero.CurrHealth;
            //Return in label Block.
            LblRightHeroBlockDamage.Text = "Block: " + battle.InfoLabelBlock;
            //Return in label taken damage.
            LblRightHeroTakeDamage.Text = "Taken damage: " + battle.InfoLabelDamageTaken;

            //Use "DoAttack" method right hero declare attack. 
            leftHero.CurrHealth = battle.DoAttack(rightHero.SpecialAttack(), leftHero.CurrHealth, leftHero.SpecialBlock());
            //Every time after attack we return the current health.
            LblLeftHealth.Text = "Heatlth: " + leftHero.Health + "/" + leftHero.CurrHealth;
            //Return in label Block.
            LblLeftHeroBlockDamage.Text = "Block: " + battle.InfoLabelBlock;
            //Return in label taken damage.
            LblLeftHeroTakeDamage.Text = "Taken damage: " + battle.InfoLabelDamageTaken;

            //if right hero's current health = 0 and left hero's current health = 0
            //Game and we return they are draw.
            //if only right hero's current health = 0
            //Game end and we return the winner.
            //if only left hero's current health = 0
            //Game end and we return the winner.
            if (battle.isDead(rightHero.CurrHealth) && battle.isDead(leftHero.CurrHealth))
            {
                timer1.Stop();
                MessageBox.Show("Congratulations", "Draw");
            } 
            else if(battle.isDead(rightHero.CurrHealth)) 
            {
                timer1.Stop();
                MessageBox.Show("Congratulations", "Left hero win!");
            }
            else if (battle.isDead(leftHero.CurrHealth))
            {
                timer1.Stop();
                MessageBox.Show("Congratulations", "Right hero win!");
            }
        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            //We are returned in StartForm.
            StartForm startForm = new StartForm();
            this.Hide();
            startForm.Show();
        }
    }
}
