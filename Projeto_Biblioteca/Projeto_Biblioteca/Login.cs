using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Biblioteca
{
    public partial class Login : Form
    {
        public string strConexao = "server=localhost;uid=root;database=sgb_newton;port=3304";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            var conexao = new MySqlConnection(strConexao);

            MySqlCommand query = new MySqlCommand("SELECT Matricula FROM usuarios WHERE Matricula = '" + txtMatricula.Text + "'", conexao);
            

            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);
            foreach(DataRow list in dataTable.Rows)
            {
                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    this.Hide();
                    Home home = new Home();
                    home.Show();
                    MessageBox.Show("Usuário Validado!");
                }
                else
                {
                    MessageBox.Show("Usuário Inválido!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registro = new Registro();
            registro.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
