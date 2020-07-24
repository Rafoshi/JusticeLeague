using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace BatSystem.View
{
    public partial class EquipAdd : Form
    {
        string stringConnection = "datasource=localhost;port=3306;Initial Catalog='db_justiceLeague';username=root;password=";
        public EquipAdd()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(stringConnection);
                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO `db_justiceleague`.`equipamentos` (`nome_equipamento`, `descricao`, `finalidade`) VALUES ('"+txtBoxNome.Text+"','"+txtBoxDesc.Text+"','"+txtBoxFinalidade.Text+"');";
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Registrado com sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
