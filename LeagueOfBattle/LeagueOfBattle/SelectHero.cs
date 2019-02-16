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
    public partial class SelectHero : Form 
    {
        GameEngine check = new GameEngine();

        public SelectHero()
        {
            InitializeComponent();
        }

        private void SelectHero_Load(object sender, EventArgs e)
        {
                
        }

        //Choose Warrior.
        private void BtnWarrior_Click(object sender, EventArgs e)
        {
            //When we click first time we create our left hero and we do the variable 
            //"IsLockLeftHero" = true.
            if (check.IsSelectHero)
            {
                //Print right side warrior's picture.
                PicBoxRightHero.Image = Properties.Resources.RightWarrior;
                Warrior rightWarrior = new Warrior(69, 616, 35);
                //Print right side warrior's attributes.
                GrBoxRight.Text = "Right hero";
                LblAttack2.Text = "Attack: " + rightWarrior.Attack.ToString();
                LblHealth2.Text = "Health: " + rightWarrior.Health.ToString();
                LblArrmor2.Text = "Arrmor: " + rightWarrior.Arrmor.ToString();
                LblRightHeroAbility.Text = "No special ability.";
                //We check if the hero is lock.
                check.IsLockRightHero = true;
                //Use this variable to get who is the locked hero.
                GameEngine.SelectRightWarrior = true;
                GameEngine.SelectRightKnight = false;
                GameEngine.SelectRightAssassin = false;
                GameEngine.SelectRightMage = false;
                GameEngine.SelectRightMarksman = false;
                
            }
            else
            {
                //Print left side warrior's picture.
                PicBoxLeftHero.Image = Properties.Resources.LeftWarrior;
                Warrior leftWarrior = new Warrior(69, 616, 35);
                //Print left side warrior's attributes.
                GrBoxLeft.Text = "Left hero";
                LblAttack.Text = "Attack: " + leftWarrior.Attack.ToString();
                LblHealth.Text = "Health: " + leftWarrior.Health.ToString();
                LblArrmor.Text = "Arrmor: " + leftWarrior.Arrmor.ToString();
                LblLeftHeroAbility.Text = "No special ability.";
                //We check if the hero is lock.
                check.IsLockLeftHero = true;
                //Use this variable to get who is the locked hero.
                GameEngine.SelectLeftWarrior = true;
                GameEngine.SelectLeftKnight = false;
                GameEngine.SelectLeftAssassin = false;
                GameEngine.SelectLeftMage = false;
                GameEngine.SelectLeftMarksman = false;
            }
            
        }

        //Choose Knight
        private void BtnKnight_Click(object sender, EventArgs e)
        {
            //When we click first time we create our left hero and we do the variable 
            //"IsLockLeftHero" = true.
            if (check.IsSelectHero)
            {
                //Print right side knight's picture.
                PicBoxRightHero.Image = Properties.Resources.RightKnight;
                Knight rightKnight = new Knight(66, 597, 36);
                //Print right side knight's attributes.
                GrBoxRight.Text = "Right hero";
                LblAttack2.Text = "Attack: " + rightKnight.Attack.ToString();
                LblHealth2.Text = "Health: " + rightKnight.Health.ToString();
                LblArrmor2.Text = "Arrmor: " + rightKnight.Arrmor.ToString();
                LblRightHeroAbility.Text = "Has a 20% chance to block the attack.\nHas a 10% chance to do 200% damage.";
                //We check if the hero is lock.
                check.IsLockRightHero = true;
                //Use this variable to get who is the locked hero.
                GameEngine.SelectRightWarrior = false;
                GameEngine.SelectRightKnight = true;
                GameEngine.SelectRightAssassin = false;
                GameEngine.SelectRightMage = false;
                GameEngine.SelectRightMarksman = false;
            }
            else
            {
                //Print left side knight's picture.
                PicBoxLeftHero.Image = Properties.Resources.LeftKnight;
                Knight leftKnight = new Knight(66, 597, 36);
                //Print left side knight's attributes.
                GrBoxLeft.Text = "Left hero";
                LblAttack.Text = "Attack: " + leftKnight.Attack.ToString();
                LblHealth.Text = "Health: " + leftKnight.Health.ToString();
                LblArrmor.Text = "Arrmor: " + leftKnight.Arrmor.ToString();
                LblLeftHeroAbility.Text = "Has a 20% chance to block the attack.\nHas a 10% chance to do 200% damage.";
                //We check if the hero is lock.
                check.IsLockLeftHero = true;
                //Use this variable to get who is the locked hero.
                GameEngine.SelectLeftWarrior = false;
                GameEngine.SelectLeftKnight = true;
                GameEngine.SelectLeftAssassin = false;
                GameEngine.SelectLeftMage = false;
                GameEngine.SelectLeftMarksman = false;
            }
            
        }

        //Choose Assassin
        private void BtnAssassin_Click(object sender, EventArgs e)
        {
            //When we click first time we create our left hero and we do the variable 
            //"IsLockLeftHero" = true.
            if (check.IsSelectHero)
            {
                //Print right side assassin's picture.
                PicBoxRightHero.Image = Properties.Resources.RightAssassin;
                Assassin rightAssassin = new Assassin(61, 515, 21);
                //Print right side assassin's attributes.
                GrBoxRight.Text = "Right hero";
                LblAttack2.Text = "Attack: " + rightAssassin.Attack.ToString();
                LblHealth2.Text = "Health: " + rightAssassin.Health.ToString();
                LblArrmor2.Text = "Arrmor: " + rightAssassin.Arrmor.ToString();
                LblRightHeroAbility.Text = "Has a 30% chance to do 300% damage.";
                //We check if the hero is lock.
                check.IsLockRightHero = true;
                //Use this variable to get who is the locked hero.
                GameEngine.SelectRightWarrior = false;
                GameEngine.SelectRightKnight = false;
                GameEngine.SelectRightAssassin = true;
                GameEngine.SelectRightMage = false;
                GameEngine.SelectRightMarksman = false;
            }
            else
            {
                //Print left side assassin's picture.
                PicBoxLeftHero.Image = Properties.Resources.LeftAssassin;
                Assassin leftAssassin = new Assassin(61, 515, 21);
                //Print left side assassin's attributes.
                GrBoxLeft.Text = "Left hero";
                LblAttack.Text = "Attack: " + leftAssassin.Attack.ToString();
                LblHealth.Text = "Health: " + leftAssassin.Health.ToString();
                LblArrmor.Text = "Arrmor: " + leftAssassin.Arrmor.ToString();
                LblLeftHeroAbility.Text = "Has a 30% chance to do 300% damage.";
                //We check if the hero is lock.
                check.IsLockLeftHero = true;
                //Use this variable to get who is the locked hero.
                GameEngine.SelectLeftWarrior = false;
                GameEngine.SelectLeftKnight = false;
                GameEngine.SelectLeftAssassin = true;
                GameEngine.SelectLeftMage = false;
                GameEngine.SelectLeftMarksman = false;
            }
        }

        //Choose Mage
        private void BtnMage_Click(object sender, EventArgs e)
        {
            //When we click first time we create our left hero and we do the variable 
            //"IsLockLeftHero" = true.
            if (check.IsSelectHero)
            {
                //Print right side mage's picture.
                PicBoxRightHero.Image = Properties.Resources.RightMage;
                Mage rightMage = new Mage(63, 570, 28);
                //Print right side mage's attributes.
                GrBoxRight.Text = "Right hero";
                LblAttack2.Text = "Attack: " + rightMage.Attack.ToString();
                LblHealth2.Text = "Health: " + rightMage.Health.ToString();
                LblArrmor2.Text = "Arrmor: " + rightMage.Arrmor.ToString();
                LblRightHeroAbility.Text = "Has a 30% chance to block the attack.";
                //We check if the hero is lock.
                check.IsLockRightHero = true;
                //Use this variable to get who is the locked hero.
                GameEngine.SelectRightWarrior = false;
                GameEngine.SelectRightKnight = false;
                GameEngine.SelectRightAssassin = false;
                GameEngine.SelectRightMage = true;
                GameEngine.SelectRightMarksman = false;
            }
            else
            {
                //Print left side mage's picture.
                PicBoxLeftHero.Image = Properties.Resources.LeftMage;
                Mage leftMage = new Mage(63, 570, 28);
                //Print left side mage's attributes.
                GrBoxLeft.Text = "Left hero";
                LblAttack.Text = "Attack: " + leftMage.Attack.ToString();
                LblHealth.Text = "Health: " + leftMage.Health.ToString();
                LblArrmor.Text = "Arrmor: " + leftMage.Arrmor.ToString();
                LblLeftHeroAbility.Text = "Has a 30% chance to block the attack.";
                //We check if the hero is lock.
                check.IsLockLeftHero = true;
                //Use this variable to get who is the locked hero.
                GameEngine.SelectLeftWarrior = false;
                GameEngine.SelectLeftKnight = false;
                GameEngine.SelectLeftAssassin = false;
                GameEngine.SelectLeftMage = true;
                GameEngine.SelectLeftMarksman = false;
            }
        }

        //Choose Marksman
        private void BtnMarksman_Click(object sender, EventArgs e)
        {
            //When we click first time we create our left hero and we do the variable 
            //"IsLockLeftHero" = true.
            if (check.IsSelectHero)
            {
                //Print right side marksman's picture.
                PicBoxRightHero.Image = Properties.Resources.RightMarksman;
                Marksman rightMarksman = new Marksman(66, 498, 28);
                //Print right side marksman's attributes.
                GrBoxRight.Text = "Right hero";
                LblAttack2.Text = "Attack: " + rightMarksman.Attack.ToString();
                LblHealth2.Text = "Health: " + rightMarksman.Health.ToString();
                LblArrmor2.Text = "Arrmor: " + rightMarksman.Arrmor.ToString();
                LblRightHeroAbility.Text = "Has a 30% chance to restore his health\nwith a half of his attack.";
                //We check if the hero is lock.
                check.IsLockRightHero = true;
                //Use this variable to get who is the locked hero.
                GameEngine.SelectRightWarrior = false;
                GameEngine.SelectRightKnight = false;
                GameEngine.SelectRightAssassin = false;
                GameEngine.SelectRightMage = false;
                GameEngine.SelectRightMarksman = true;
            }
            else
            {
                //Print left side marksman's picture.
                PicBoxLeftHero.Image = Properties.Resources.LeftMarksman;
                Marksman leftMarksman = new Marksman(66, 498, 28);
                //Print left side marksman's attributes.
                GrBoxLeft.Text = "Left hero";
                LblAttack.Text = "Attack: " + leftMarksman.Attack.ToString();
                LblHealth.Text = "Health: " + leftMarksman.Health.ToString();
                LblArrmor.Text = "Arrmor: " + leftMarksman.Arrmor.ToString();
                LblLeftHeroAbility.Text = "Has a 30% chance to restore his health\nwith a half of his attack.";
                //We check if the hero is lock.
                check.IsLockLeftHero = true;
                //Use this variable to get who is the locked hero.
                GameEngine.SelectLeftWarrior = false;
                GameEngine.SelectLeftKnight = false;
                GameEngine.SelectLeftAssassin = false;
                GameEngine.SelectLeftMage = false;
                GameEngine.SelectLeftMarksman = true;
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            //Close game.
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            //If we dont select left hero we can't choose right hero.
            if (check.IsLockLeftHero)
            {
                LblSelect.Text = "Choose second hero.";
                check.IsSelectHero = true;
            }
        }

        private void PicBoxLeftHero_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //When we choose left and right hero we open the battle form.
            //if not, return MassageBox.
            if (check.IsLockLeftHero && check.IsLockRightHero)
            {
                Battle battleForm = new Battle();
                this.Hide();
                battleForm.Show();
            }
            else
            {
                MessageBox.Show("You should choose a hero.", "Oops");
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            //We are returned in StartForm.
            StartForm startForm = new StartForm();
            this.Hide();
            startForm.Show();
        }

     
    }
}
