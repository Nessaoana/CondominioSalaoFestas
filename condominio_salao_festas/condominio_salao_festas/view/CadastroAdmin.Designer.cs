namespace condominio_salao_festas.view
{
    partial class CadastroAdmin
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
            this.nome = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.txtNomeValor = new System.Windows.Forms.TextBox();
            this.txtEmailValor = new System.Windows.Forms.TextBox();
            this.txtSenhaValor = new System.Windows.Forms.TextBox();
            this.validador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(193, 74);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(62, 24);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome";
            this.nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(194, 117);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(57, 24);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(194, 165);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(65, 24);
            this.senha.TabIndex = 2;
            this.senha.Text = "Senha";
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(292, 256);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 3;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // txtNomeValor
            // 
            this.txtNomeValor.Location = new System.Drawing.Point(292, 74);
            this.txtNomeValor.Name = "txtNomeValor";
            this.txtNomeValor.Size = new System.Drawing.Size(161, 20);
            this.txtNomeValor.TabIndex = 4;
            this.txtNomeValor.TextChanged += new System.EventHandler(this.nomeValor_TextChanged);
            // 
            // txtEmailValor
            // 
            this.txtEmailValor.Location = new System.Drawing.Point(292, 117);
            this.txtEmailValor.Name = "txtEmailValor";
            this.txtEmailValor.Size = new System.Drawing.Size(161, 20);
            this.txtEmailValor.TabIndex = 5;
            // 
            // txtSenhaValor
            // 
            this.txtSenhaValor.Location = new System.Drawing.Point(292, 165);
            this.txtSenhaValor.Name = "txtSenhaValor";
            this.txtSenhaValor.Size = new System.Drawing.Size(161, 20);
            this.txtSenhaValor.TabIndex = 6;
            // 
            // validador
            // 
            this.validador.AutoSize = true;
            this.validador.Location = new System.Drawing.Point(195, 323);
            this.validador.Name = "validador";
            this.validador.Size = new System.Drawing.Size(0, 13);
            this.validador.TabIndex = 7;
            this.validador.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CadastroAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validador);
            this.Controls.Add(this.txtSenhaValor);
            this.Controls.Add(this.txtEmailValor);
            this.Controls.Add(this.txtNomeValor);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nome);
            this.Name = "CadastroAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CadastroAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TextBox txtNomeValor;
        private System.Windows.Forms.TextBox txtEmailValor;
        private System.Windows.Forms.TextBox txtSenhaValor;
        private System.Windows.Forms.Label validador;
    }
}