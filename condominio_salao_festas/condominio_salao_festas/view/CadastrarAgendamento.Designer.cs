namespace condominio_salao_festas.view
{
    partial class frmCadastrarAgendamento
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
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.btnReservarAgendamento = new System.Windows.Forms.Button();
            this.dtDataReserva = new System.Windows.Forms.MonthCalendar();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.lblApartamento = new System.Windows.Forms.Label();
            this.cbMoradores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(139, 347);
            this.lblDetalhes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(0, 17);
            this.lblDetalhes.TabIndex = 21;
            // 
            // btnReservarAgendamento
            // 
            this.btnReservarAgendamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarAgendamento.Location = new System.Drawing.Point(404, 383);
            this.btnReservarAgendamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservarAgendamento.Name = "btnReservarAgendamento";
            this.btnReservarAgendamento.Size = new System.Drawing.Size(147, 40);
            this.btnReservarAgendamento.TabIndex = 20;
            this.btnReservarAgendamento.Text = "Reservar";
            this.btnReservarAgendamento.UseVisualStyleBackColor = true;
            this.btnReservarAgendamento.Click += new System.EventHandler(this.btnCadastrarAgendamento_Click);
            // 
            // dtDataReserva
            // 
            this.dtDataReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataReserva.Location = new System.Drawing.Point(143, 137);
            this.dtDataReserva.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.dtDataReserva.MaxSelectionCount = 1;
            this.dtDataReserva.Name = "dtDataReserva";
            this.dtDataReserva.TabIndex = 19;
            this.dtDataReserva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dtDataReserva_DateChanged);
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.Location = new System.Drawing.Point(187, 27);
            this.lblNomeCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(176, 23);
            this.lblNomeCompleto.TabIndex = 17;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtApartamento
            // 
            this.txtApartamento.Enabled = false;
            this.txtApartamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartamento.Location = new System.Drawing.Point(28, 67);
            this.txtApartamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(129, 32);
            this.txtApartamento.TabIndex = 16;
            this.txtApartamento.TextChanged += new System.EventHandler(this.txtApartamento_TextChanged);
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartamento.Location = new System.Drawing.Point(24, 27);
            this.lblApartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(144, 23);
            this.lblApartamento.TabIndex = 15;
            this.lblApartamento.Text = "Apartamento";
            // 
            // cbMoradores
            // 
            this.cbMoradores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoradores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoradores.FormattingEnabled = true;
            this.cbMoradores.Location = new System.Drawing.Point(191, 67);
            this.cbMoradores.Name = "cbMoradores";
            this.cbMoradores.Size = new System.Drawing.Size(360, 31);
            this.cbMoradores.TabIndex = 22;
            this.cbMoradores.SelectedIndexChanged += new System.EventHandler(this.cbMoradores_SelectedIndexChanged);
            // 
            // frmCadastrarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 434);
            this.Controls.Add(this.cbMoradores);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.btnReservarAgendamento);
            this.Controls.Add(this.dtDataReserva);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtApartamento);
            this.Controls.Add(this.lblApartamento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastrarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento do Salão de Festas";
            this.Load += new System.EventHandler(this.frmCadastrarAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.Button btnReservarAgendamento;
        private System.Windows.Forms.MonthCalendar dtDataReserva;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.Label lblApartamento;
        private System.Windows.Forms.ComboBox cbMoradores;
    }
}