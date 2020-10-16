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
            this.dtGridCancelarAgendamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIrParaAgendamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCancelarAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarAgendamento
            // 
            this.btnCancelarAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAgendamento.Location = new System.Drawing.Point(224, 371);
            this.btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            this.btnCancelarAgendamento.Size = new System.Drawing.Size(190, 37);
            this.btnCancelarAgendamento.TabIndex = 27;
            this.btnCancelarAgendamento.Text = "Cancelar Reserva";
            this.btnCancelarAgendamento.UseVisualStyleBackColor = true;
            this.btnCancelarAgendamento.Click += new System.EventHandler(this.btnCancelarAgendamento_Click);
            // 
            // dtGridCancelarAgendamento
            // 
            this.dtGridCancelarAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCancelarAgendamento.Location = new System.Drawing.Point(35, 64);
            this.dtGridCancelarAgendamento.MultiSelect = false;
            this.dtGridCancelarAgendamento.Name = "dtGridCancelarAgendamento";
            this.dtGridCancelarAgendamento.ReadOnly = true;
            this.dtGridCancelarAgendamento.RowHeadersWidth = 51;
            this.dtGridCancelarAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridCancelarAgendamento.ShowEditingIcon = false;
            this.dtGridCancelarAgendamento.Size = new System.Drawing.Size(379, 282);
            this.dtGridCancelarAgendamento.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gerenciar Agendamentos";
            // 
            // btnIrParaAgendamento
            // 
            this.btnIrParaAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaAgendamento.Location = new System.Drawing.Point(86, 371);
            this.btnIrParaAgendamento.Name = "btnIrParaAgendamento";
            this.btnIrParaAgendamento.Size = new System.Drawing.Size(118, 36);
            this.btnIrParaAgendamento.TabIndex = 31;
            this.btnIrParaAgendamento.Text = "Agendar";
            this.btnIrParaAgendamento.UseVisualStyleBackColor = true;
            this.btnIrParaAgendamento.Click += new System.EventHandler(this.btnIrParaAgendamento_Click);
            // 
            // frmCancelarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 418);
            this.Controls.Add(this.btnIrParaAgendamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridCancelarAgendamento);
            this.Controls.Add(this.btnCancelarAgendamento);
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
        private System.Windows.Forms.DataGridView dtGridCancelarAgendamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIrParaAgendamento;
    }
}