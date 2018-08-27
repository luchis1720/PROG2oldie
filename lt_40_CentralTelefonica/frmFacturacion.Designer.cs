namespace lt_40_CentralTelefonica
{
    partial class frmFacturacion
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
            this.rchtFacturacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchtFacturacion
            // 
            this.rchtFacturacion.Enabled = false;
            this.rchtFacturacion.Location = new System.Drawing.Point(12, 12);
            this.rchtFacturacion.Name = "rchtFacturacion";
            this.rchtFacturacion.Size = new System.Drawing.Size(260, 238);
            this.rchtFacturacion.TabIndex = 0;
            this.rchtFacturacion.Text = "";
            this.rchtFacturacion.TextChanged += new System.EventHandler(this.rchtFacturacion_TextChanged);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rchtFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFacturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtFacturacion;
    }
}