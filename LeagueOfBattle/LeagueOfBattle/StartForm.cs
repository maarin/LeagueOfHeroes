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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            //Open messagebox for game info.
            MessageBox.Show("\"League of Battle\" you can choose your hero\n" + 
                            "Warrior, Knight, Assassin, Mage or Marksman.\n" +
                            "When you choose your heroes, you can start the game.\n" +
                            "The game goes in turns. First hero declare attack and\n" +
                            "second hero declare attack. If one of their life go zero\n" +
                            "the other hero win.\n\n" +
                            "Created by Marin Georgiev", "Game info");
        }

        private void BtnPLay_Click(object sender, EventArgs e)
        {
            //Close "StartForm" and open "SelectHero".
            SelectHero selectForm = new SelectHero();
            this.Hide();
            selectForm.Show();
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
