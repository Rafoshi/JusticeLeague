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
    public partial class VillanQuery : Form
    {

        string stringConnection = "datasource=localhost;port=3306;Initial Catalog='db_justiceLeague';username=root;password=";
        public VillanQuery()
        {
            InitializeComponent();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxQuery_TextChanged(object sender, EventArgs e)
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

        private void dgVillan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VillanQuery_Load(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(stringConnection);
            connection.Open();

            string query = "SELECT v.nome_vilao,v.codinome,v.especie,v.habilidade,v.vulnerabilidade,v.nivel_de_acesso,v.esconderijo, h.nome_heroi,e.nome_equipamento, e.descricao,e.finalidade FROM db_justiceleague.viloes as v join equipamentos as e join herois as h   on v.fk_equipamentos_id = e.id_equipamentos and v.fk_herois_rivais = h.id_heroi;";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgVillan.DataSource = table;

            dgVillan.Columns[0].HeaderText = "Nome";
            dgVillan.Columns[1].HeaderText = "Codinome";
            dgVillan.Columns[2].HeaderText = "Especie";
            dgVillan.Columns[3].HeaderText = "Habilidade"; 
            dgVillan.Columns[4].HeaderText = "Vulnerabilidade";
            dgVillan.Columns[8].HeaderText = "Nome equipamento";
            dgVillan.Columns[9].HeaderText = "Descrição"; 
            dgVillan.Columns[5].HeaderText = "Nivel de acesso";
            dgVillan.Columns[6].HeaderText = "Esconderijo";
            dgVillan.Columns[7].HeaderText = "Herói rival"; 
            dgVillan.Columns[8].HeaderText = "Nome equipamento";
            dgVillan.Columns[9].HeaderText = "Descrição";
            dgVillan.Columns[10].HeaderText = "Finalidade";

            dgVillan.Columns[0].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgVillan.Columns[1].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgVillan.Columns[2].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgVillan.Columns[3].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgVillan.Columns[4].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgVillan.Columns[5].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgVillan.Columns[6].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgVillan.Columns[7].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgVillan.Columns[8].HeaderCell.Style.Font = new Font("Roboto", 9);
            dgVillan.Columns[9].HeaderCell.Style.Font = new Font("Roboto", 9);

            connection.Close();
        }
    }
}
