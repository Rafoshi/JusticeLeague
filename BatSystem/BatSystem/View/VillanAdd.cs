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

    public partial class VillanAdd : Form
    {
        string stringConnection = "datasource=localhost;port=3306;Initial Catalog='db_justiceLeague';username=root;password=";
        public VillanAdd()
        {
            InitializeComponent();
            FillComboEquip();
            FillComboHero();
        }

        public void FillComboEquip()
        {
            MySqlConnection connection = new MySqlConnection(stringConnection);
            string Query = "SELECT nome_equipamento FROM db_justiceleague.equipamentos;";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nome = reader.GetString("nome_equipamento");
                    comboBox.Items.Add(nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void FillComboHero()
        {
            MySqlConnection connection = new MySqlConnection(stringConnection);
            string Query = "SELECT nome_heroi FROM db_justiceleague.herois;";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nome = reader.GetString("nome_heroi");
                    comboBox1.Items.Add(nome);
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

                int comboBoxHeroIndex = comboBox1.SelectedIndex + 1;
                int comboBoxEquipIndex = comboBox.SelectedIndex + 1;

                cmd.CommandText = "INSERT INTO `db_justiceleague`.`viloes` (`nome_vilao`, `codinome`, `especie`, `vulnerabilidade`, `nivel_de_acesso`, `habilidade`, `esconderijo`, `fk_herois_rivais`, `fk_equipamentos_id`) VALUES ('"+txtBoxNome.Text+"', '"+txtBoxHabilidade.Text+"', '"+txtBoxEspecie.Text+"', '"+txtBoxVulnerabilidade.Text+"', '"+txtBoxNivelDeAcesso.Text+"', '"+txtBoxHabilidade.Text+"', '"+txtBoxEsconderijo.Text+"', '"+ comboBoxHeroIndex + "', '"+ comboBoxEquipIndex + "');";
                
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
