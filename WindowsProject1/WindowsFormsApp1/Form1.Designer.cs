namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cONVERSIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINARIODECIMALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dECIMALBINARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINARIOOCTALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINARIOHEXADECIMALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONVERSIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cONVERSIONESToolStripMenuItem
            // 
            this.cONVERSIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bINARIODECIMALToolStripMenuItem,
            this.dECIMALBINARIOToolStripMenuItem,
            this.bINARIOOCTALToolStripMenuItem,
            this.bINARIOHEXADECIMALToolStripMenuItem});
            this.cONVERSIONESToolStripMenuItem.Name = "cONVERSIONESToolStripMenuItem";
            this.cONVERSIONESToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.cONVERSIONESToolStripMenuItem.Text = "CONVERSIONES";
            // 
            // bINARIODECIMALToolStripMenuItem
            // 
            this.bINARIODECIMALToolStripMenuItem.Name = "bINARIODECIMALToolStripMenuItem";
            this.bINARIODECIMALToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bINARIODECIMALToolStripMenuItem.Text = "BINARIO DECIMAL";
            // 
            // dECIMALBINARIOToolStripMenuItem
            // 
            this.dECIMALBINARIOToolStripMenuItem.Name = "dECIMALBINARIOToolStripMenuItem";
            this.dECIMALBINARIOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dECIMALBINARIOToolStripMenuItem.Text = "DECIMAL BINARIO";
            // 
            // bINARIOOCTALToolStripMenuItem
            // 
            this.bINARIOOCTALToolStripMenuItem.Name = "bINARIOOCTALToolStripMenuItem";
            this.bINARIOOCTALToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bINARIOOCTALToolStripMenuItem.Text = "BINARIO OCTAL";
            // 
            // bINARIOHEXADECIMALToolStripMenuItem
            // 
            this.bINARIOHEXADECIMALToolStripMenuItem.Name = "bINARIOHEXADECIMALToolStripMenuItem";
            this.bINARIOHEXADECIMALToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.bINARIOHEXADECIMALToolStripMenuItem.Text = "BINARIO HEXADECIMAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONVERSIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINARIODECIMALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dECIMALBINARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINARIOOCTALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINARIOHEXADECIMALToolStripMenuItem;
    }
}

