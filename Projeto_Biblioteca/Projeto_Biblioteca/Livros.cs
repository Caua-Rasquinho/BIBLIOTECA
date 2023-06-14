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
    public partial class Livros : Form
    {
        public string strConexao = "server=localhost;uid=root;database=sgb_newton;port=3304";

        public Livros()
        {
            InitializeComponent();

            lstLivros.View = View.Details;
            lstLivros.LabelEdit = true;
            lstLivros.AllowColumnReorder = true;
            lstLivros.FullRowSelect = true;
            lstLivros.GridLines = true;

            lstLivros.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstLivros.Columns.Add("Título", 150, HorizontalAlignment.Left);
            lstLivros.Columns.Add("Autor", 150, HorizontalAlignment.Left);
            lstLivros.Columns.Add("Editora", 150, HorizontalAlignment.Left);
            lstLivros.Columns.Add("Ano", 150, HorizontalAlignment.Left);
            lstLivros.Columns.Add("Categoria", 150, HorizontalAlignment.Left);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            var conexao = new MySqlConnection(strConexao);
            conexao.Open();

            string q = "%" + txtBusca.Text + "%";
            string sql = "SELECT * " +
                         "FROM livros " +
                         "WHERE titulo_livro LIKE '" + q + "' OR autor_livro LIKE '" + q + "'"; 

            var comando = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            lstLivros.Items.Clear();

            while (reader.Read())
            {
                string[] row =
                {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                };

                var linha_list = new ListViewItem(row);
                lstLivros.Items.Add(linha_list);
            }

            


        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();

            var comando = new MySqlCommand("DELETE FROM livros WHERE titulo_livro = '" + txtAlugar.Text + "' limit 1", conexao);
            comando.ExecuteReader();   
            MessageBox.Show("O seu livro foi alugado, certifique-se de devolvê-lo no prazo combinado!");

            var conexao2 = new MySqlConnection(strConexao);
            conexao2.Open();
            var comando2 = new MySqlCommand("INSERT INTO emprestimos(id_livro, id_usuario, Data_Emprestimo, Data_Devolucao) " +
                                            "VALUES(" + int.Parse(txtIdLivro.Text) + ", " + int.Parse(txtIdUsuario.Text) + ", '" + txtEmprestimo.Text + "', '" + txtDevolucao.Text + "')", conexao2);
            comando2.ExecuteReader();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
