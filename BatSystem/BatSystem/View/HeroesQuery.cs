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

namespace BatSystem
{
    public partial class HeroesQuery : Form
    {

        string stringConnection = "datasource=localhost;port=3306;Initial Catalog='db_justiceLeague';username=root;password=";
        public HeroesQuery()
        {
            InitializeComponent();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void picBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void HeroesQuery_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(stringConnection);
                connection.Open();

                string query = "SELECT h.nome_heroi,h.codinome,h.especie,h.vulnerabilidade,h.nivel_de_acessso, e.nome_equipamento, e.descricao,e.finalidade FROM db_justiceleague.herois as h join equipamentos as e on h.fk_equipamentos_id = e.id_equipamentos order by h.nome_heroi;";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(table);
                dgHeroes.DataSource = table;

                dgHeroes.Columns[0].HeaderText = "Nome";
                dgHeroes.Columns[1].HeaderText = "Codinome";
                dgHeroes.Columns[2].HeaderText = "Especie";
                dgHeroes.Columns[3].HeaderText = "Vulnerabilidade";
                dgHeroes.Columns[4].HeaderText = "Nível de Acesso";
                dgHeroes.Columns[5].HeaderText = "Nome equipamento";
                dgHeroes.Columns[6].HeaderText = "Descrição";
                dgHeroes.Columns[7].HeaderText = "Finalidade";

                dgHeroes.Columns[0].HeaderCell.Style.Font = new Font("Roboto", 9);
                dgHeroes.Columns[1].HeaderCell.Style.Font = new Font("Roboto", 9);
                dgHeroes.Columns[2].HeaderCell.Style.Font = new Font("Roboto", 9);
                dgHeroes.Columns[3].HeaderCell.Style.Font = new Font("Roboto", 9);
                dgHeroes.Columns[4].HeaderCell.Style.Font = new Font("Roboto", 9);
                dgHeroes.Columns[5].HeaderCell.Style.Font = new Font("Roboto", 9);
                dgHeroes.Columns[6].HeaderCell.Style.Font = new Font("Roboto", 9);
                dgHeroes.Columns[7].HeaderCell.Style.Font = new Font("Roboto", 9);

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgHeroes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxQuery_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
