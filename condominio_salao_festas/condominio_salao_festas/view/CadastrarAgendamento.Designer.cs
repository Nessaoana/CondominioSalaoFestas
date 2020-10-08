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
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.lblApartamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(104, 269);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(0, 13);
            this.lblDetalhes.TabIndex = 21;
            // 
            // btnReservarAgendamento
            // 
            this.btnReservarAgendamento.Location = new System.Drawing.Point(338, 308);
            this.btnReservarAgendamento.Name = "btnReservarAgendamento";
            this.btnReservarAgendamento.Size = new System.Drawing.Size(75, 23);
            this.btnReservarAgendamento.TabIndex = 20;
            this.btnReservarAgendamento.Text = "Reservar";
            this.btnReservarAgendamento.UseVisualStyleBackColor = true;
            this.btnReservarAgendamento.Click += new System.EventHandler(this.btnCadastrarAgendamento_Click);
            // 
            // dtDataReserva
            // 
            this.dtDataReserva.Location = new System.Drawing.Point(107, 98);
            this.dtDataReserva.MaxSelectionCount = 1;
            this.dtDataReserva.Name = "dtDataReserva";
            this.dtDataReserva.TabIndex = 19;
            this.dtDataReserva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dtDataReserva_DateChanged);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Enabled = false;
            this.txtNomeCompleto.Location = new System.Drawing.Point(107, 38);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(306, 20);
            this.txtNomeCompleto.TabIndex = 18;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(104, 22);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompleto.TabIndex = 17;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtApartamento
            // 
            this.txtApartamento.Enabled = false;
            this.txtApartamento.Location = new System.Drawing.Point(34, 38);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(64, 20);
            this.txtApartamento.TabIndex = 16;
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Location = new System.Drawing.Point(31, 22);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(67, 13);
            this.lblApartamento.TabIndex = 15;
            this.lblApartamento.Text = "Apartamento";
            // 
            // frmCadastrarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 353);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.btnReservarAgendamento);
            this.Controls.Add(this.dtDataReserva);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtApartamento);
            this.Controls.Add(this.lblApartamento);
            this.Name = "frmCadastrarAgendamento";
            this.Text = "Agendamento do Salão de Festas";
            this.Load += new System.EventHandler(this.frmCadastrarAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.Button btnReservarAgendamento;
        private System.Windows.Forms.MonthCalendar dtDataReserva;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.Label lblApartamento;
    }
}