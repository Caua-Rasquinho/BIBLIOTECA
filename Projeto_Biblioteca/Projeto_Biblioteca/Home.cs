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
    public partial class Home : Form
    {
        public string strConexao = "server=localhost;uid=root;database=sgb_newton;port=3304";
        public bool professor;
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();

            MySqlCommand comando = new MySqlCommand("SELECT cargo FROM usuarios WHERE cargo = 'Professor'", conexao);

            DataTable datatable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(datatable);


            foreach (DataRow list in datatable.Rows)
            {
                if (list.ItemArray[0].ToString() == "Professor")
                {
                    professor = true;
                } else
                {
                    professor = false;
                }
            }
            if (professor)
            {
                this.Hide();
                AdicionarLivro addbook = new AdicionarLivro();
                addbook.Show();
            }  else
            {
                MessageBox.Show("Você não é um professor!");
            }
 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Livros livros = new Livros();
            livros.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registro = new Registro();
            registro.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
