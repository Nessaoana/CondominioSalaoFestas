﻿namespace condominio_salao_festas
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
            this.btnAgendamentosLista = new System.Windows.Forms.Button();
            this.btnIrParaAgendamento = new System.Windows.Forms.Button();
            this.btnCancelarAgendamento = new System.Windows.Forms.Button();
            this.cadastrarMorador = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.btnApartamentos = new System.Windows.Forms.Button();
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
            // btnAgendamentosLista
            // 
            this.btnAgendamentosLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamentosLista.Location = new System.Drawing.Point(655, 341);
            this.btnAgendamentosLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgendamentosLista.Name = "btnAgendamentosLista";
            this.btnAgendamentosLista.Size = new System.Drawing.Size(113, 49);
            this.btnAgendamentosLista.TabIndex = 3;
            this.btnAgendamentosLista.Text = "Acessar agendamentos";
            this.btnAgendamentosLista.UseVisualStyleBackColor = true;
            this.btnAgendamentosLista.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIrParaAgendamento
            // 
            this.btnIrParaAgendamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaAgendamento.Location = new System.Drawing.Point(655, 398);
            this.btnIrParaAgendamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnIrParaAgendamento.Name = "btnIrParaAgendamento";
            this.btnIrParaAgendamento.Size = new System.Drawing.Size(113, 49);
            this.btnIrParaAgendamento.TabIndex = 4;
            this.btnIrParaAgendamento.Text = "Agendar";
            this.btnIrParaAgendamento.UseVisualStyleBackColor = true;
            this.btnIrParaAgendamento.Click += new System.EventHandler(this.btnIrParaAgendamento_Click);
            // 
            // btnCancelarAgendamento
            // 
            this.btnCancelarAgendamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAgendamento.Location = new System.Drawing.Point(655, 454);
            this.btnCancelarAgendamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            this.btnCancelarAgendamento.Size = new System.Drawing.Size(113, 49);
            this.btnCancelarAgendamento.TabIndex = 5;
            this.btnCancelarAgendamento.Text = "Cancelar";
            this.btnCancelarAgendamento.UseVisualStyleBackColor = true;
            this.btnCancelarAgendamento.Click += new System.EventHandler(this.btnCancelarAgendamento_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 554);
            this.Controls.Add(this.btnApartamentos);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.cadastrarMorador);
            this.Controls.Add(this.btnCancelarAgendamento);
            this.Controls.Add(this.btnIrParaAgendamento);
            this.Controls.Add(this.btnAgendamentosLista);
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
        private System.Windows.Forms.Button btnAgendamentosLista;
        private System.Windows.Forms.Button btnIrParaAgendamento;
        private System.Windows.Forms.Button btnCancelarAgendamento;
        private System.Windows.Forms.Button cadastrarMorador;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Button btnApartamentos;
    }
}

