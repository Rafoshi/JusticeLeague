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
    public partial class AttackAdd : Form
    {
        string stringConnection = "datasource=localhost;port=3306;Initial Catalog='db_justiceLeague';username=root;password=";
        public AttackAdd()
        {
            InitializeComponent();
            FillCombo();
        }

        public void FillCombo()
        {
            MySqlConnection connection = new MySqlConnection(stringConnection);
            string Query = "SELECT nome_vilao FROM db_justiceleague.viloes;";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nome = reader.GetString("nome_vilao");
                    comboBox.Items.Add(nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                int comboBoxIndex = comboBox.SelectedIndex + 1;
                cmd.CommandText = "INSERT INTO `db_justiceleague`.`ataques` (`local_ataque`, `data_ataque`, `hora`, `fk_vilao`) VALUES ('"+txtBoxLocal.Text+"', '"+txtData.Text+"', '"+txtTime.Text+"', '"+comboBoxIndex+"');";
                
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
