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
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace Projeto_Biblioteca
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        public string strConexao = "server=localhost;uid=root;database=sgb_newton;port=3304";
        public string cargo = "";
        /*
        public class Livro
        {
            [Key]
            public int Id { get; set; }
            public string Autor { get; set; }
            public string Titulo { get; set; }
            public string Editora { get; set; }
            public int AnoPubli { get; set; }
            public string Categoria { get; set; }

        }
        public class Cliente
        {
            [Key]
            public int Id { get; set; }
            public string Nome { get; set; }
            public int Matricula { get; set; }
            public string Endereco { get; set; }
            public int Telefone { get; set; }
        }

        public class Emprestimo
        {
            [Key]
            public int IdEmprestimo { get; set; }
            public int IdLivro { get; set; }
            public int IdCliente { get; set; }
            public string DataEmprestimo { get; set; }
            public string DataDevolucao { get; set; }
        }
        public class MeuContexto : DbContext
        {
            public DbSet<Livro> Livro { get; set; }
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Emprestimo> Emprestimo { get; set; }
        }
        */

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {         
            if (txtNome.Text == "")
            {
                MessageBox.Show("Erro! Complete todos os campos!");
            } else if (txtEndereco.Text == "") {
                MessageBox.Show("Erro! Complete todos os campos!");
            } else if (txtMatricula.Text == "")
            {
                MessageBox.Show("Erro! Complete todos os campos!");
            } else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Erro! Complete todos os campos!");
            } else if (rdoAluno.Checked == false && rdoProfessor.Checked == false)
            {
                MessageBox.Show("Erro! Complete todos os campos!");
            } 
            else 
            {
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                if (rdoAluno.Checked)
                {
                    cargo = "Aluno";
                    var comando = new MySqlCommand("INSERT INTO usuarios (nome_usuario, Matricula, Endereço, telefone, cargo) VALUES" +
                                                "('" + txtNome.Text + "', '" + txtMatricula.Text + "', '" + txtEndereco.Text + "', '" + txtTelefone.Text + "', '" + cargo + "')", conexao);
                    comando.ExecuteReader();
                } 
                if (rdoProfessor.Checked)
                {
                    cargo = "Professor";
                    var comando = new MySqlCommand("INSERT INTO usuarios (nome_usuario, Matricula, Endereço, telefone, cargo) VALUES" +
                                                "('" + txtNome.Text + "', '" + txtMatricula.Text + "', '" + txtEndereco.Text + "', '" + txtTelefone.Text + "', '" + cargo + "')", conexao);
                    comando.ExecuteReader();
                }
                
                

                this.Hide();
                Home home = new Home();
                home.Show();


            }

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                var strConexao = "server=localhost;uid=root;database=sgb_newton;port=3304";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                MessageBox.Show("Conexão OK!");


                var comando = new MySqlCommand("SELECT * FROM usuarios", conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show($"{reader["id_usuario"]} => {reader["nome_usuario"]}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar com o BD: " + ex.Message);
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
