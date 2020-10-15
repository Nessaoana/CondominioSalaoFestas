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
            this.txtNomeValor = new System.Windows.Forms.TextBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.Label();
            this.apartamento = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbApartamento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSenhaValor
            // 
            this.txtSenhaValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaValor.Location = new System.Drawing.Point(214, 284);
            this.txtSenhaValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaValor.Name = "txtSenhaValor";
            this.txtSenhaValor.Size = new System.Drawing.Size(273, 32);
            this.txtSenhaValor.TabIndex = 13;
            this.txtSenhaValor.TextChanged += new System.EventHandler(this.txtSenhaValor_TextChanged);
            // 
            // txtNomeValor
            // 
            this.txtNomeValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeValor.Location = new System.Drawing.Point(214, 172);
            this.txtNomeValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeValor.Name = "txtNomeValor";
            this.txtNomeValor.Size = new System.Drawing.Size(273, 32);
            this.txtNomeValor.TabIndex = 11;
            this.txtNomeValor.TextChanged += new System.EventHandler(this.txtNomeValor_TextChanged);
            // 
            // cadastrar
            // 
            this.cadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Location = new System.Drawing.Point(315, 350);
            this.cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(172, 43);
            this.cadastrar.TabIndex = 10;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(43, 278);
            this.senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(71, 23);
            this.senha.TabIndex = 9;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // apartamento
            // 
            this.apartamento.AutoSize = true;
            this.apartamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartamento.Location = new System.Drawing.Point(43, 228);
            this.apartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apartamento.Name = "apartamento";
            this.apartamento.Size = new System.Drawing.Size(144, 23);
            this.apartamento.TabIndex = 8;
            this.apartamento.Text = "Apartamento";
            this.apartamento.Click += new System.EventHandler(this.email_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(43, 172);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(70, 23);
            this.nome.TabIndex = 7;
            this.nome.Text = "Nome";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de Morador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(214, 112);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(245, 32);
            this.txtId.TabIndex = 15;
            this.txtId.Visible = false;
            // 
            // cbApartamento
            // 
            this.cbApartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApartamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApartamento.FormattingEnabled = true;
            this.cbApartamento.Location = new System.Drawing.Point(214, 228);
            this.cbApartamento.Name = "cbApartamento";
            this.cbApartamento.Size = new System.Drawing.Size(273, 31);
            this.cbApartamento.TabIndex = 16;
            this.cbApartamento.SelectedIndexChanged += new System.EventHandler(this.cbApartamento_SelectedIndexChanged);
            // 
            // CadastroMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 436);
            this.Controls.Add(this.cbApartamento);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtSenhaValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeValor);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.apartamento);
            this.Controls.Add(this.nome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroMorador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Morador";
            this.Load += new System.EventHandler(this.CadastroMorador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenhaValor;
        private System.Windows.Forms.TextBox txtNomeValor;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Label apartamento;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbApartamento;
    }
}