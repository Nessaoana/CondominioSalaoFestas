namespace condominio_salao_festas.view
{
    partial class frmAlterarAgendamento
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
            this.dtGridCancelarAgendamento = new System.Windows.Forms.DataGridView();
            this.btnAlterarAgendamento = new System.Windows.Forms.Button();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.lblApartamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCancelarAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridCancelarAgendamento
            // 
            this.dtGridCancelarAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCancelarAgendamento.Location = new System.Drawing.Point(34, 64);
            this.dtGridCancelarAgendamento.MultiSelect = false;
            this.dtGridCancelarAgendamento.Name = "dtGridCancelarAgendamento";
            this.dtGridCancelarAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridCancelarAgendamento.ShowEditingIcon = false;
            this.dtGridCancelarAgendamento.Size = new System.Drawing.Size(379, 238);
            this.dtGridCancelarAgendamento.TabIndex = 35;
            // 
            // btnAlterarAgendamento
            // 
            this.btnAlterarAgendamento.Location = new System.Drawing.Point(293, 308);
            this.btnAlterarAgendamento.Name = "btnAlterarAgendamento";
            this.btnAlterarAgendamento.Size = new System.Drawing.Size(120, 23);
            this.btnAlterarAgendamento.TabIndex = 34;
            this.btnAlterarAgendamento.Text = "Alterar Reserva";
            this.btnAlterarAgendamento.UseVisualStyleBackColor = true;
            this.btnAlterarAgendamento.Click += new System.EventHandler(this.btnAlterarAgendamento_Click);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Enabled = false;
            this.txtNomeCompleto.Location = new System.Drawing.Point(107, 38);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(306, 20);
            this.txtNomeCompleto.TabIndex = 33;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(104, 22);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompleto.TabIndex = 32;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtApartamento
            // 
            this.txtApartamento.Enabled = false;
            this.txtApartamento.Location = new System.Drawing.Point(34, 38);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(64, 20);
            this.txtApartamento.TabIndex = 31;
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Location = new System.Drawing.Point(31, 22);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(67, 13);
            this.lblApartamento.TabIndex = 30;
            this.lblApartamento.Text = "Apartamento";
            // 
            // frmAlterarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 353);
            this.Controls.Add(this.dtGridCancelarAgendamento);
            this.Controls.Add(this.btnAlterarAgendamento);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtApartamento);
            this.Controls.Add(this.lblApartamento);
            this.Name = "frmAlterarAgendamento";
            this.Text = "Alterar Agendamento";
            this.Load += new System.EventHandler(this.frmAlterarAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCancelarAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridCancelarAgendamento;
        private System.Windows.Forms.Button btnAlterarAgendamento;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.Label lblApartamento;
    }
}