using BatSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void picBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblAtttack_Click(object sender, EventArgs e)
        {

        }

        private void btnHero_Click(object sender, EventArgs e)
        {
            HeroesQuery heroes = new HeroesQuery();
            heroes.Show();
            this.Hide();
        }

        private void btnVillan_Click(object sender, EventArgs e)
        {
            VillanQuery villanQuery = new VillanQuery();
            villanQuery.Show();
            this.Hide();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            AttackAdd attack = new AttackAdd();
            attack.Show();
            this.Hide();
        }

        private void batlogoCenter_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            EquipAdd equip = new EquipAdd();
            equip.Show();
            this.Hide();
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            HeroesAdd heroes = new HeroesAdd();
            heroes.Show();
            this.Hide();
        }

        private void btnAddVilan_Click(object sender, EventArgs e)
        {
            VillanAdd villian = new VillanAdd();
            villian.Show();
            this.Hide();
        }

        private void btnVillainConsul_Click(object sender, EventArgs e)
        {
            AttackQuery attack = new AttackQuery();
            attack.Show();
            this.Hide();
        }
    }
}
