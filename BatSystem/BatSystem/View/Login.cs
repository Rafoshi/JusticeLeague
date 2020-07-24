using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BatSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            txtBoxUser.Focus();
        }
        
        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string input = (txtBoxUser.Text).ToLower();
                if (input == "batman")
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
                else if (input != "batman")
                {
                    MessageBox.Show("Você não tem nivel de acesso suficiente.","Acesso Negado",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Por favor insira algo válido");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ClearText(object sender, EventArgs e)
        {
            txtBoxUser.Text = "";
        }
    }
}
