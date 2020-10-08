namespace condominio_salao_festas.view
{
    partial class frmEscolherDataAlterarAgendamento
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
            this.btnConfirmarAlteração = new System.Windows.Forms.Button();
            this.dtDataReserva = new System.Windows.Forms.MonthCalendar();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.lblApartamento = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtCodigoReserva = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(104, 311);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(0, 13);
            this.lblDetalhes.TabIndex = 28;
            // 
            // btnConfirmarAlteração
            // 
            this.btnConfirmarAlteração.Location = new System.Drawing.Point(279, 350);
            this.btnConfirmarAlteração.Name = "btnConfirmarAlteração";
            this.btnConfirmarAlteração.Size = new System.Drawing.Size(134, 23);
            this.btnConfirmarAlteração.TabIndex = 27;
            this.btnConfirmarAlteração.Text = "Confirmar Alteração";
            this.btnConfirmarAlteração.UseVisualStyleBackColor = true;
            this.btnConfirmarAlteração.Click += new System.EventHandler(this.btnConfirmarAlteração_Click);
            // 
            // dtDataReserva
            // 
            this.dtDataReserva.Location = new System.Drawing.Point(107, 140);
            this.dtDataReserva.MaxSelectionCount = 1;
            this.dtDataReserva.Name = "dtDataReserva";
            this.dtDataReserva.TabIndex = 26;
            this.dtDataReserva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dtDataReserva_DateChanged);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Enabled = false;
            this.txtNomeCompleto.Location = new System.Drawing.Point(107, 38);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(306, 20);
            this.txtNomeCompleto.TabIndex = 25;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(104, 22);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompleto.TabIndex = 24;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtApartamento
            // 
            this.txtApartamento.Enabled = false;
            this.txtApartamento.Location = new System.Drawing.Point(34, 38);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(64, 20);
            this.txtApartamento.TabIndex = 23;
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Location = new System.Drawing.Point(31, 22);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(67, 13);
            this.lblApartamento.TabIndex = 22;
            this.lblApartamento.Text = "Apartamento";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(152, 72);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 13);
            this.lblDe.TabIndex = 29;
            this.lblDe.Text = "De";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(290, 72);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(29, 13);
            this.lblPara.TabIndex = 30;
            this.lblPara.Text = "Para";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(155, 88);
            this.txtDe.Name = "txtDe";
            this.txtDe.ReadOnly = true;
            this.txtDe.Size = new System.Drawing.Size(120, 20);
            this.txtDe.TabIndex = 31;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(293, 88);
            this.txtPara.Name = "txtPara";
            this.txtPara.ReadOnly = true;
            this.txtPara.Size = new System.Drawing.Size(120, 20);
            this.txtPara.TabIndex = 32;
            // 
            // txtCodigoReserva
            // 
            this.txtCodigoReserva.Location = new System.Drawing.Point(34, 88);
            this.txtCodigoReserva.Name = "txtCodigoReserva";
            this.txtCodigoReserva.ReadOnly = true;
            this.txtCodigoReserva.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoReserva.TabIndex = 33;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(31, 72);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(98, 13);
            this.lblCodigo.TabIndex = 34;
            this.lblCodigo.Text = "Codigo da Reserva";
            // 
            // frmEscolherDataAlterarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 385);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigoReserva);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.btnConfirmarAlteração);
            this.Controls.Add(this.dtDataReserva);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtApartamento);
            this.Controls.Add(this.lblApartamento);
            this.Name = "frmEscolherDataAlterarAgendamento";
            this.Text = "Escolher Data";
            this.Load += new System.EventHandler(this.frmEscolherDataAlterarAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.Button btnConfirmarAlteração;
        private System.Windows.Forms.MonthCalendar dtDataReserva;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.Label lblApartamento;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtCodigoReserva;
        private System.Windows.Forms.Label lblCodigo;
    }
}