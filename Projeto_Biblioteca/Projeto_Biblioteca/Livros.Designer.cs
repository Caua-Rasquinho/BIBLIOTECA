
namespace Projeto_Biblioteca
{
    partial class Livros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstLivros = new System.Windows.Forms.ListView();
            this.txtAlugar = new System.Windows.Forms.TextBox();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmprestimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDevolucao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(38, 107);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(570, 35);
            this.txtBusca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONSULTAR LIVROS";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(614, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstLivros
            // 
            this.lstLivros.HideSelection = false;
            this.lstLivros.Location = new System.Drawing.Point(38, 148);
            this.lstLivros.Name = "lstLivros";
            this.lstLivros.Size = new System.Drawing.Size(731, 164);
            this.lstLivros.TabIndex = 4;
            this.lstLivros.UseCompatibleStateImageBehavior = false;
            // 
            // txtAlugar
            // 
            this.txtAlugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlugar.Location = new System.Drawing.Point(186, 365);
            this.txtAlugar.Name = "txtAlugar";
            this.txtAlugar.Size = new System.Drawing.Size(239, 35);
            this.txtAlugar.TabIndex = 5;
            // 
            // btnAlugar
            // 
            this.btnAlugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugar.Location = new System.Drawing.Point(586, 431);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(155, 35);
            this.btnAlugar.TabIndex = 6;
            this.btnAlugar.Text = "Alugar";
            this.btnAlugar.UseVisualStyleBackColor = true;
            this.btnAlugar.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Título: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data Empréstimo: ";
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmprestimo.Location = new System.Drawing.Point(263, 542);
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.Size = new System.Drawing.Size(239, 35);
            this.txtEmprestimo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 604);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data Devolução: ";
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevolucao.Location = new System.Drawing.Point(263, 601);
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.Size = new System.Drawing.Size(239, 35);
            this.txtDevolucao.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID Usuário: ";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(186, 487);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(239, 35);
            this.txtIdUsuario.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID Livro: ";
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdLivro.Location = new System.Drawing.Point(186, 428);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(239, 35);
            this.txtIdLivro.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(649, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Biblioteca.Properties.Resources._360_F_527338742_YJLZpfdlLqWWECi8yubDg7AOV2If3paO;
            this.ClientSize = new System.Drawing.Size(828, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdLivro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDevolucao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmprestimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.txtAlugar);
            this.Controls.Add(this.lstLivros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Name = "Livros";
            this.Text = "Livros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lstLivros;
        private System.Windows.Forms.TextBox txtAlugar;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmprestimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDevolucao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.Button button1;
    }
}