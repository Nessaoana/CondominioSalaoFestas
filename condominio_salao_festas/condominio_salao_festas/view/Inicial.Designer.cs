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
            this.btnCriarAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginAbrir = new System.Windows.Forms.Button();
            this.btnAgendamentosLista = new System.Windows.Forms.Button();
            this.btnIrParaAgendamento = new System.Windows.Forms.Button();
            this.btnCancelarAgendamento = new System.Windows.Forms.Button();
            this.cadastrarMorador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarAdmin
            // 
            this.btnCriarAdmin.Location = new System.Drawing.Point(289, 277);
            this.btnCriarAdmin.Name = "btnCriarAdmin";
            this.btnCriarAdmin.Size = new System.Drawing.Size(85, 40);
            this.btnCriarAdmin.TabIndex = 0;
            this.btnCriarAdmin.Text = "Criar usuário ADMIN";
            this.btnCriarAdmin.UseVisualStyleBackColor = true;
            this.btnCriarAdmin.Click += new System.EventHandler(this.button1_Click);
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
            // btnLoginAbrir
            // 
            this.btnLoginAbrir.Location = new System.Drawing.Point(82, 277);
            this.btnLoginAbrir.Name = "btnLoginAbrir";
            this.btnLoginAbrir.Size = new System.Drawing.Size(85, 40);
            this.btnLoginAbrir.TabIndex = 2;
            this.btnLoginAbrir.Text = "Login";
            this.btnLoginAbrir.UseVisualStyleBackColor = true;
            this.btnLoginAbrir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgendamentosLista
            // 
            this.btnAgendamentosLista.Location = new System.Drawing.Point(491, 277);
            this.btnAgendamentosLista.Name = "btnAgendamentosLista";
            this.btnAgendamentosLista.Size = new System.Drawing.Size(85, 40);
            this.btnAgendamentosLista.TabIndex = 3;
            this.btnAgendamentosLista.Text = "Acessar agendamentos";
            this.btnAgendamentosLista.UseVisualStyleBackColor = true;
            this.btnAgendamentosLista.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIrParaAgendamento
            // 
            this.btnIrParaAgendamento.Location = new System.Drawing.Point(491, 323);
            this.btnIrParaAgendamento.Name = "btnIrParaAgendamento";
            this.btnIrParaAgendamento.Size = new System.Drawing.Size(85, 40);
            this.btnIrParaAgendamento.TabIndex = 4;
            this.btnIrParaAgendamento.Text = "Agendar";
            this.btnIrParaAgendamento.UseVisualStyleBackColor = true;
            this.btnIrParaAgendamento.Click += new System.EventHandler(this.btnIrParaAgendamento_Click);
            // 
            // btnCancelarAgendamento
            // 
            this.btnCancelarAgendamento.Location = new System.Drawing.Point(491, 369);
            this.btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            this.btnCancelarAgendamento.Size = new System.Drawing.Size(85, 40);
            this.btnCancelarAgendamento.TabIndex = 5;
            this.btnCancelarAgendamento.Text = "Cancelar";
            this.btnCancelarAgendamento.UseVisualStyleBackColor = true;
            this.btnCancelarAgendamento.Click += new System.EventHandler(this.btnCancelarAgendamento_Click);
            // 
            // cadastrarMorador
            // 
            this.cadastrarMorador.Location = new System.Drawing.Point(289, 323);
            this.cadastrarMorador.Name = "cadastrarMorador";
            this.cadastrarMorador.Size = new System.Drawing.Size(85, 40);
            this.cadastrarMorador.TabIndex = 6;
            this.cadastrarMorador.Text = "Criar morador";
            this.cadastrarMorador.UseVisualStyleBackColor = true;
            this.cadastrarMorador.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.cadastrarMorador);
            this.Controls.Add(this.btnCancelarAgendamento);
            this.Controls.Add(this.btnIrParaAgendamento);
            this.Controls.Add(this.btnAgendamentosLista);
            this.Controls.Add(this.btnLoginAbrir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriarAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginAbrir;
        private System.Windows.Forms.Button btnAgendamentosLista;
        private System.Windows.Forms.Button btnIrParaAgendamento;
        private System.Windows.Forms.Button btnCancelarAgendamento;
        private System.Windows.Forms.Button cadastrarMorador;
    }
}

