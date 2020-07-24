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
    public partial class AttackQuery : Form
    {
        string stringConnection = "datasource=localhost;port=3306;Initial Catalog='db_justiceLeague';username=root;password=";
        public AttackQuery()
        {
            InitializeComponent();
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

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgHeroes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AttackQuery_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(stringConnection);
            connection.Open();

            string query = "SELECT a.local_ataque,a.data_ataque,a.hora, v.nome_vilao FROM ataques as a join viloes as v on a.fk_vilao = v.id_vilao;";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgAttack.DataSource = table;

            dgAttack.Columns[0].HeaderText = "Local";
            dgAttack.Columns[1].HeaderText = "Data";
            dgAttack.Columns[2].HeaderText = "Hora";
            dgAttack.Columns[3].HeaderText = "Vilão";

            dgAttack.Columns[0].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgAttack.Columns[1].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgAttack.Columns[2].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgAttack.Columns[3].HeaderCell.Style.Font = new Font("Roboto", 9);

            connection.Close();
        }
    }
}
