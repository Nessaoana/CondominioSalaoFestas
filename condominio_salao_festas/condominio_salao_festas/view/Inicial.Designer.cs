namespace condominio_salao_festas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrarMorador = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.btnApartamentos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem vindo ao sistema de agendamento do salão de festas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cadastrarMorador
            // 
            this.cadastrarMorador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarMorador.Location = new System.Drawing.Point(247, 124);
            this.cadastrarMorador.Name = "cadastrarMorador";
            this.cadastrarMorador.Size = new System.Drawing.Size(137, 101);
            this.cadastrarMorador.TabIndex = 6;
            this.cadastrarMorador.Text = "Gerenciar Moradores";
            this.cadastrarMorador.UseVisualStyleBackColor = true;
            this.cadastrarMorador.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.Location = new System.Drawing.Point(82, 124);
            this.btnGerenciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(137, 101);
            this.btnGerenciar.TabIndex = 7;
            this.btnGerenciar.Text = "Gerenciar usuários";
            this.btnGerenciar.UseVisualStyleBackColor = true;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // btnApartamentos
            // 
            this.btnApartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartamentos.Location = new System.Drawing.Point(409, 124);
            this.btnApartamentos.Name = "btnApartamentos";
            this.btnApartamentos.Size = new System.Drawing.Size(137, 101);
            this.btnApartamentos.TabIndex = 8;
            this.btnApartamentos.Text = "Gerenciar Apartamentos";
            this.btnApartamentos.UseVisualStyleBackColor = true;
            this.btnApartamentos.Click += new System.EventHandler(this.btnApartamentos_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 101);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gerenciar Agendamentos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(476, 408);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Usuário";
            this.lblUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnApartamentos);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.cadastrarMorador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrarMorador;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Button btnApartamentos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUser;
    }
}

