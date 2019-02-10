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
    public partial class Fight : Form
    {
        public Avatar enemy;
        public Avatar myAvatar;

        public Fight()
        {
            InitializeComponent();

            enemy = new Avatar("Dummy", "Dummy", 10, 1, 1, 1, 1);
            myAvatar = new Avatar();
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            myAvatar = ((New)Owner).myAvatar;

            lblName.Text = myAvatar.Name.ToString();
            lblEnemy.Text = enemy.Name.ToString();

            enemy.Attacks.Add(new Attack("Hit", "Does damage"));
            
            foreach (Attack attack in myAvatar.Attacks)
            {
                lbxAttacks.Items.Add(attack);
            }

            RefreshHP();

            lbxAttacks.SelectedIndex = 0;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            myAvatar.HP -= enemy.Damage * enemy.Attacks[0].Multiplier;
            enemy.HP -= myAvatar.Damage * ((Attack)lbxAttacks.SelectedItem).Multiplier;

            RefreshHP();

            if (enemy.HP <= 0)
            {
                MessageBox.Show("You destroyed your enemy!");

                this.DialogResult = DialogResult.Yes;

                this.Close();
            }
            else if (myAvatar.HP <= 0)
            {
                MessageBox.Show("You died!");

                this.DialogResult = DialogResult.No;

                this.Close();
            }
        }

        private void RefreshHP()
        {
            lblMyHP.Text = myAvatar.HP.ToString();
            lblEnemyHP.Text = enemy.HP.ToString();
        }
    }
}
