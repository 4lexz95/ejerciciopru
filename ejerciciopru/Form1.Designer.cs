namespace ejerciciopru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejer2parte5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejer1ToolStripMenuItem,
            this.ejercicio2ToolStripMenuItem,
            this.votosToolStripMenuItem,
            this.ejer2parte5ToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            resources.ApplyResources(this.ejerciciosToolStripMenuItem, "ejerciciosToolStripMenuItem");
            // 
            // ejer1ToolStripMenuItem
            // 
            this.ejer1ToolStripMenuItem.Name = "ejer1ToolStripMenuItem";
            resources.ApplyResources(this.ejer1ToolStripMenuItem, "ejer1ToolStripMenuItem");
            this.ejer1ToolStripMenuItem.Click += new System.EventHandler(this.ejer1ToolStripMenuItem_Click);
            // 
            // ejercicio2ToolStripMenuItem
            // 
            this.ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
            resources.ApplyResources(this.ejercicio2ToolStripMenuItem, "ejercicio2ToolStripMenuItem");
            this.ejercicio2ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio2ToolStripMenuItem_Click);
            // 
            // votosToolStripMenuItem
            // 
            this.votosToolStripMenuItem.Name = "votosToolStripMenuItem";
            resources.ApplyResources(this.votosToolStripMenuItem, "votosToolStripMenuItem");
            this.votosToolStripMenuItem.Click += new System.EventHandler(this.votosToolStripMenuItem_Click);
            // 
            // ejer2parte5ToolStripMenuItem
            // 
            this.ejer2parte5ToolStripMenuItem.Name = "ejer2parte5ToolStripMenuItem";
            resources.ApplyResources(this.ejer2parte5ToolStripMenuItem, "ejer2parte5ToolStripMenuItem");
            this.ejer2parte5ToolStripMenuItem.Click += new System.EventHandler(this.ejer2parte5ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejer1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejer2parte5ToolStripMenuItem;
    }
}

