namespace condominio_salao_festas.view
{
    partial class frmCancelarAgendamento
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
            this.btnCancelarAgendamento = new System.Windows.Forms.Button();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.lblApartamento = new System.Windows.Forms.Label();
            this.dtGridCancelarAgendamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIrParaAgendamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCancelarAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarAgendamento
            // 
            this.btnCancelarAgendamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAgendamento.Location = new System.Drawing.Point(299, 457);
            this.btnCancelarAgendamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            this.btnCancelarAgendamento.Size = new System.Drawing.Size(253, 45);
            this.btnCancelarAgendamento.TabIndex = 27;
            this.btnCancelarAgendamento.Text = "Cancelar Reserva";
            this.btnCancelarAgendamento.UseVisualStyleBackColor = true;
            this.btnCancelarAgendamento.Click += new System.EventHandler(this.btnCancelarAgendamento_Click);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Enabled = false;
            this.txtNomeCompleto.Location = new System.Drawing.Point(145, 124);
            this.txtNomeCompleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(407, 22);
            this.txtNomeCompleto.TabIndex = 25;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(141, 104);
            this.lblNomeCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(108, 17);
            this.lblNomeCompleto.TabIndex = 24;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtApartamento
            // 
            this.txtApartamento.Enabled = false;
            this.txtApartamento.Location = new System.Drawing.Point(47, 124);
            this.txtApartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(84, 22);
            this.txtApartamento.TabIndex = 23;
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Location = new System.Drawing.Point(43, 104);
            this.lblApartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(89, 17);
            this.lblApartamento.TabIndex = 22;
            this.lblApartamento.Text = "Apartamento";
            // 
            // dtGridCancelarAgendamento
            // 
            this.dtGridCancelarAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCancelarAgendamento.Location = new System.Drawing.Point(47, 156);
            this.dtGridCancelarAgendamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGridCancelarAgendamento.MultiSelect = false;
            this.dtGridCancelarAgendamento.Name = "dtGridCancelarAgendamento";
            this.dtGridCancelarAgendamento.ReadOnly = true;
            this.dtGridCancelarAgendamento.RowHeadersWidth = 51;
            this.dtGridCancelarAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridCancelarAgendamento.ShowEditingIcon = false;
            this.dtGridCancelarAgendamento.Size = new System.Drawing.Size(505, 293);
            this.dtGridCancelarAgendamento.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gerenciar Agendamentos";
            // 
            // btnIrParaAgendamento
            // 
            this.btnIrParaAgendamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaAgendamento.Location = new System.Drawing.Point(114, 457);
            this.btnIrParaAgendamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnIrParaAgendamento.Name = "btnIrParaAgendamento";
            this.btnIrParaAgendamento.Size = new System.Drawing.Size(157, 44);
            this.btnIrParaAgendamento.TabIndex = 31;
            this.btnIrParaAgendamento.Text = "Agendar";
            this.btnIrParaAgendamento.UseVisualStyleBackColor = true;
            this.btnIrParaAgendamento.Click += new System.EventHandler(this.btnIrParaAgendamento_Click);
            // 
            // frmCancelarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 514);
            this.Controls.Add(this.btnIrParaAgendamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridCancelarAgendamento);
            this.Controls.Add(this.btnCancelarAgendamento);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtApartamento);
            this.Controls.Add(this.lblApartamento);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCancelarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar agendamento";
            this.Load += new System.EventHandler(this.frmCancelarAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCancelarAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarAgendamento;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.Label lblApartamento;
        private System.Windows.Forms.DataGridView dtGridCancelarAgendamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIrParaAgendamento;
    }
}