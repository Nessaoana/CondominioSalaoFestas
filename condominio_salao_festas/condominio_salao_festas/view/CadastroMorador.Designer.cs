namespace condominio_salao_festas.view
{
    partial class CadastroMorador
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
            this.txtSenhaValor = new System.Windows.Forms.TextBox();
            this.txtEmailValor = new System.Windows.Forms.TextBox();
            this.txtNomeValor = new System.Windows.Forms.TextBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSenhaValor
            // 
            this.txtSenhaValor.Location = new System.Drawing.Point(218, 199);
            this.txtSenhaValor.Name = "txtSenhaValor";
            this.txtSenhaValor.Size = new System.Drawing.Size(161, 20);
            this.txtSenhaValor.TabIndex = 13;
            this.txtSenhaValor.Visible = false;
            this.txtSenhaValor.TextChanged += new System.EventHandler(this.txtSenhaValor_TextChanged);
            // 
            // txtEmailValor
            // 
            this.txtEmailValor.Location = new System.Drawing.Point(218, 151);
            this.txtEmailValor.Name = "txtEmailValor";
            this.txtEmailValor.Size = new System.Drawing.Size(161, 20);
            this.txtEmailValor.TabIndex = 12;
            this.txtEmailValor.TextChanged += new System.EventHandler(this.txtEmailValor_TextChanged);
            // 
            // txtNomeValor
            // 
            this.txtNomeValor.Location = new System.Drawing.Point(218, 108);
            this.txtNomeValor.Name = "txtNomeValor";
            this.txtNomeValor.Size = new System.Drawing.Size(161, 20);
            this.txtNomeValor.TabIndex = 11;
            this.txtNomeValor.TextChanged += new System.EventHandler(this.txtNomeValor_TextChanged);
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(218, 290);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 10;
            this.cadastrar.Text = "klk";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(120, 199);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(65, 24);
            this.senha.TabIndex = 9;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(120, 151);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(81, 24);
            this.email.TabIndex = 8;
            this.email.Text = "Morador";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(119, 108);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(62, 24);
            this.nome.TabIndex = 7;
            this.nome.Text = "Nome";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de Morador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CadastroMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaValor);
            this.Controls.Add(this.txtEmailValor);
            this.Controls.Add(this.txtNomeValor);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nome);
            this.Name = "CadastroMorador";
            this.Text = "CadastroMorador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenhaValor;
        private System.Windows.Forms.TextBox txtEmailValor;
        private System.Windows.Forms.TextBox txtNomeValor;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label label1;
    }
}