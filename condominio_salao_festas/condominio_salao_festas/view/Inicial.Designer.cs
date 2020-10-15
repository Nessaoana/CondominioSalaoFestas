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
            this.btnLoginAbrir = new System.Windows.Forms.Button();
            this.cadastrarMorador = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.btnApartamentos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem vindo ao sistema de agendamento do salão de festas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoginAbrir
            // 
            this.btnLoginAbrir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAbrir.Location = new System.Drawing.Point(37, 424);
            this.btnLoginAbrir.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginAbrir.Name = "btnLoginAbrir";
            this.btnLoginAbrir.Size = new System.Drawing.Size(113, 49);
            this.btnLoginAbrir.TabIndex = 2;
            this.btnLoginAbrir.Text = "Login";
            this.btnLoginAbrir.UseVisualStyleBackColor = true;
            this.btnLoginAbrir.Click += new System.EventHandler(this.button2_Click);
            // 
            // cadastrarMorador
            // 
            this.cadastrarMorador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarMorador.Location = new System.Drawing.Point(307, 148);
            this.cadastrarMorador.Margin = new System.Windows.Forms.Padding(4);
            this.cadastrarMorador.Name = "cadastrarMorador";
            this.cadastrarMorador.Size = new System.Drawing.Size(183, 124);
            this.cadastrarMorador.TabIndex = 6;
            this.cadastrarMorador.Text = "Gerenciar Moradores";
            this.cadastrarMorador.UseVisualStyleBackColor = true;
            this.cadastrarMorador.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.Location = new System.Drawing.Point(87, 148);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(183, 124);
            this.btnGerenciar.TabIndex = 7;
            this.btnGerenciar.Text = "Gerenciar usuários";
            this.btnGerenciar.UseVisualStyleBackColor = true;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // btnApartamentos
            // 
            this.btnApartamentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartamentos.Location = new System.Drawing.Point(522, 148);
            this.btnApartamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnApartamentos.Name = "btnApartamentos";
            this.btnApartamentos.Size = new System.Drawing.Size(183, 124);
            this.btnApartamentos.TabIndex = 8;
            this.btnApartamentos.Text = "Gerenciar Apartamentos";
            this.btnApartamentos.UseVisualStyleBackColor = true;
            this.btnApartamentos.Click += new System.EventHandler(this.btnApartamentos_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(307, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 124);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gerenciar Agendamentos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnApartamentos);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.cadastrarMorador);
            this.Controls.Add(this.btnLoginAbrir);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginAbrir;
        private System.Windows.Forms.Button cadastrarMorador;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Button btnApartamentos;
        private System.Windows.Forms.Button button1;
    }
}

