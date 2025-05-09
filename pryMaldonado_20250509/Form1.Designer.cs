namespace pryMaldonado_20250509
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbClubes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClubes
            // 
            this.cmbClubes.FormattingEnabled = true;
            this.cmbClubes.Location = new System.Drawing.Point(34, 60);
            this.cmbClubes.Name = "cmbClubes";
            this.cmbClubes.Size = new System.Drawing.Size(133, 21);
            this.cmbClubes.TabIndex = 0;
            this.cmbClubes.SelectedIndexChanged += new System.EventHandler(this.cmbClubes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clubes";
            // 
            // pbImagenes
            // 
            this.pbImagenes.Image = global::pryMaldonado_20250509.Properties.Resources.iacc;
            this.pbImagenes.Location = new System.Drawing.Point(34, 119);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(169, 130);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenes.TabIndex = 2;
            this.pbImagenes.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 274);
            this.Controls.Add(this.pbImagenes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClubes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClubes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImagenes;
    }
}

