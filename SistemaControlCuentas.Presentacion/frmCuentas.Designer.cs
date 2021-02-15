namespace SistemaControlCuentas.Presentacion
{
    partial class frmCuentas
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
            this.dtgCuentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCuentas
            // 
            this.dtgCuentas.AllowUserToAddRows = false;
            this.dtgCuentas.AllowUserToDeleteRows = false;
            this.dtgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCuentas.Location = new System.Drawing.Point(12, 62);
            this.dtgCuentas.Name = "dtgCuentas";
            this.dtgCuentas.ReadOnly = true;
            this.dtgCuentas.Size = new System.Drawing.Size(518, 248);
            this.dtgCuentas.TabIndex = 0;
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 372);
            this.Controls.Add(this.dtgCuentas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.frmCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCuentas;
    }
}