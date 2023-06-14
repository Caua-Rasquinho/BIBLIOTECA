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
    public partial class AdicionarLivro : Form
    {
        public AdicionarLivro()
        {
            InitializeComponent();
        }

        public string strConexao = "server=localhost;uid=root;database=sgb_newton;port=3304";

        private void button1_Click(object sender, EventArgs e)
        {
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();

            var comando = new MySqlCommand("INSERT INTO livros (titulo_livro, autor_livro, Editora_livro, Ano_Publicacao, categoria) VALUES" +
                                                "('" + txtTitulo.Text + "', '" + txtAutor.Text + "', '" + txtEditora.Text + "', '" + txtAno.Text + "', '" + txtCategoria.Text + "')", conexao);
            comando.ExecuteReader();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
