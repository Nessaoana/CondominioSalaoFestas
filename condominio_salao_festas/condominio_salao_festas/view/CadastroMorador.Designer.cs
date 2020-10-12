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
            this.apartamento = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarMoradorMenu = new System.Windows.Forms.Button();
            this.btnListaMoradoresMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInicialAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSenhaValor
            // 
            this.txtSenhaValor.Location = new System.Drawing.Point(419, 188);
            this.txtSenhaValor.Name = "txtSenhaValor";
            this.txtSenhaValor.Size = new System.Drawing.Size(161, 20);
            this.txtSenhaValor.TabIndex = 13;
            this.txtSenhaValor.Visible = false;
            this.txtSenhaValor.TextChanged += new System.EventHandler(this.txtSenhaValor_TextChanged);
            // 
            // txtEmailValor
            // 
            this.txtEmailValor.Location = new System.Drawing.Point(419, 140);
            this.txtEmailValor.Name = "txtEmailValor";
            this.txtEmailValor.Size = new System.Drawing.Size(161, 20);
            this.txtEmailValor.TabIndex = 12;
            this.txtEmailValor.TextChanged += new System.EventHandler(this.txtEmailValor_TextChanged);
            // 
            // txtNomeValor
            // 
            this.txtNomeValor.Location = new System.Drawing.Point(419, 97);
            this.txtNomeValor.Name = "txtNomeValor";
            this.txtNomeValor.Size = new System.Drawing.Size(161, 20);
            this.txtNomeValor.TabIndex = 11;
            this.txtNomeValor.TextChanged += new System.EventHandler(this.txtNomeValor_TextChanged);
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(419, 278);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 10;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(291, 183);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(65, 24);
            this.senha.TabIndex = 9;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // apartamento
            // 
            this.apartamento.AutoSize = true;
            this.apartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartamento.Location = new System.Drawing.Point(291, 136);
            this.apartamento.Name = "apartamento";
            this.apartamento.Size = new System.Drawing.Size(117, 24);
            this.apartamento.TabIndex = 8;
            this.apartamento.Text = "Apartamento";
            this.apartamento.Click += new System.EventHandler(this.email_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(291, 97);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(62, 24);
            this.nome.TabIndex = 7;
            this.nome.Text = "Nome";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de Morador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadastrarMoradorMenu
            // 
            this.btnCadastrarMoradorMenu.Location = new System.Drawing.Point(18, 154);
            this.btnCadastrarMoradorMenu.Name = "btnCadastrarMoradorMenu";
            this.btnCadastrarMoradorMenu.Size = new System.Drawing.Size(158, 25);
            this.btnCadastrarMoradorMenu.TabIndex = 15;
            this.btnCadastrarMoradorMenu.Text = "Cadastrar Morador";
            this.btnCadastrarMoradorMenu.UseVisualStyleBackColor = true;
            // 
            // btnListaMoradoresMenu
            // 
            this.btnListaMoradoresMenu.Location = new System.Drawing.Point(18, 206);
            this.btnListaMoradoresMenu.Name = "btnListaMoradoresMenu";
            this.btnListaMoradoresMenu.Size = new System.Drawing.Size(158, 23);
            this.btnListaMoradoresMenu.TabIndex = 16;
            this.btnListaMoradoresMenu.Text = "Lista de moradores";
            this.btnListaMoradoresMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Menu Admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnInicialAdmin
            // 
            this.btnInicialAdmin.Location = new System.Drawing.Point(18, 99);
            this.btnInicialAdmin.Name = "btnInicialAdmin";
            this.btnInicialAdmin.Size = new System.Drawing.Size(158, 25);
            this.btnInicialAdmin.TabIndex = 18;
            this.btnInicialAdmin.Text = "Inicio";
            this.btnInicialAdmin.UseVisualStyleBackColor = true;
            // 
            // CadastroMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.btnInicialAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListaMoradoresMenu);
            this.Controls.Add(this.btnCadastrarMoradorMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaValor);
            this.Controls.Add(this.txtEmailValor);
            this.Controls.Add(this.txtNomeValor);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.apartamento);
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
        private System.Windows.Forms.Label apartamento;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarMoradorMenu;
        private System.Windows.Forms.Button btnListaMoradoresMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInicialAdmin;
    }
}