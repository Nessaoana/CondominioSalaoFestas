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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(32, 145);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(70, 23);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome";
            this.nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(34, 198);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(62, 23);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(34, 257);
            this.senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(71, 23);
            this.senha.TabIndex = 2;
            this.senha.Text = "Senha";
            // 
            // cadastrar
            // 
            this.cadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Location = new System.Drawing.Point(352, 318);
            this.cadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(132, 51);
            this.cadastrar.TabIndex = 3;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // txtNomeValor
            // 
            this.txtNomeValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeValor.Location = new System.Drawing.Point(164, 145);
            this.txtNomeValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeValor.Name = "txtNomeValor";
            this.txtNomeValor.Size = new System.Drawing.Size(320, 32);
            this.txtNomeValor.TabIndex = 4;
            this.txtNomeValor.TextChanged += new System.EventHandler(this.nomeValor_TextChanged);
            // 
            // txtEmailValor
            // 
            this.txtEmailValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailValor.Location = new System.Drawing.Point(164, 198);
            this.txtEmailValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailValor.Name = "txtEmailValor";
            this.txtEmailValor.Size = new System.Drawing.Size(320, 32);
            this.txtEmailValor.TabIndex = 5;
            // 
            // txtSenhaValor
            // 
            this.txtSenhaValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaValor.Location = new System.Drawing.Point(164, 257);
            this.txtSenhaValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenhaValor.Name = "txtSenhaValor";
            this.txtSenhaValor.Size = new System.Drawing.Size(320, 32);
            this.txtSenhaValor.TabIndex = 6;
            // 
            // validador
            // 
            this.validador.AutoSize = true;
            this.validador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validador.Location = new System.Drawing.Point(35, 452);
            this.validador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validador.Name = "validador";
            this.validador.Size = new System.Drawing.Size(0, 23);
            this.validador.TabIndex = 7;
            this.validador.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(164, 97);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(245, 32);
            this.txtId.TabIndex = 8;
            this.txtId.Visible = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AllowDrop = true;
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(141, 38);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(268, 28);
            this.txtTitulo.TabIndex = 9;
            this.txtTitulo.Text = "Cadastro de Usuários:";
            this.txtTitulo.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // CadastroAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 403);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.validador);
            this.Controls.Add(this.txtSenhaValor);
            this.Controls.Add(this.txtEmailValor);
            this.Controls.Add(this.txtNomeValor);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadastroAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
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
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label txtTitulo;
    }
}