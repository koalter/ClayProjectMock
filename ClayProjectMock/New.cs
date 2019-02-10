using ClayProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClayProjectMock
{
    public partial class New : Form
    {
        public Avatar myAvatar;

        public New()
        {
            InitializeComponent();

            myAvatar = new Avatar("Player1", "Warrior", 10, 10, 18, 12, 9);

            myAvatar.Attacks.Add(new Attack("Slash", "Swings the weapon towards the enemy."));
        }

        private void New_Load(object sender, EventArgs e)
        {
            lblName.Text = myAvatar.Name;
            lblClass.Text = myAvatar.Job;
            lblHP.Text = myAvatar.HP.ToString();
            lblStr.Text = myAvatar.Stats.Strength.ToString();
            lblAgi.Text = myAvatar.Stats.Agility.ToString();
            lblInt.Text = myAvatar.Stats.Intelligence.ToString();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblFight_Click(object sender, EventArgs e)
        {
            if (myAvatar.HP > 0)
            {
                var beginFight = new Fight();
                beginFight.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("It seems you don't have any HP left. Here, let me heal you!");
                myAvatar.HP += 10;
            }

            lblHP.Text = myAvatar.HP.ToString();
        }
    }
}
