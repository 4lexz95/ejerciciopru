namespace ejerciciopru
{
    partial class ejer1
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
            this.gbing = new System.Windows.Forms.GroupBox();
            this.cbcebo = new System.Windows.Forms.CheckBox();
            this.cbtomna = new System.Windows.Forms.CheckBox();
            this.cbanc = new System.Windows.Forms.CheckBox();
            this.cbbac = new System.Windows.Forms.CheckBox();
            this.rbgran = new System.Windows.Forms.RadioButton();
            this.rbmed = new System.Windows.Forms.RadioButton();
            this.rbpeq = new System.Windows.Forms.RadioButton();
            this.gbtam = new System.Windows.Forms.GroupBox();
            this.bttotal = new System.Windows.Forms.Button();
            this.lbtot = new System.Windows.Forms.Label();
            this.lbres = new System.Windows.Forms.Label();
            this.nudunidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gbing.SuspendLayout();
            this.gbtam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudunidad)).BeginInit();
            this.SuspendLayout();
            // 
            // gbing
            // 
            this.gbing.Controls.Add(this.cbcebo);
            this.gbing.Controls.Add(this.cbtomna);
            this.gbing.Controls.Add(this.cbanc);
            this.gbing.Controls.Add(this.cbbac);
            this.gbing.Location = new System.Drawing.Point(83, 40);
            this.gbing.Name = "gbing";
            this.gbing.Size = new System.Drawing.Size(199, 170);
            this.gbing.TabIndex = 0;
            this.gbing.TabStop = false;
            this.gbing.Text = "Ingredientes:";
            // 
            // cbcebo
            // 
            this.cbcebo.AutoSize = true;
            this.cbcebo.Location = new System.Drawing.Point(27, 130);
            this.cbcebo.Name = "cbcebo";
            this.cbcebo.Size = new System.Drawing.Size(76, 20);
            this.cbcebo.TabIndex = 7;
            this.cbcebo.Text = "Cebolla";
            this.cbcebo.UseVisualStyleBackColor = true;
            // 
            // cbtomna
            // 
            this.cbtomna.AutoSize = true;
            this.cbtomna.Location = new System.Drawing.Point(27, 101);
            this.cbtomna.Name = "cbtomna";
            this.cbtomna.Size = new System.Drawing.Size(119, 20);
            this.cbtomna.TabIndex = 6;
            this.cbtomna.Text = "Tomate natural";
            this.cbtomna.UseVisualStyleBackColor = true;
            // 
            // cbanc
            // 
            this.cbanc.AutoSize = true;
            this.cbanc.Location = new System.Drawing.Point(27, 75);
            this.cbanc.Name = "cbanc";
            this.cbanc.Size = new System.Drawing.Size(82, 20);
            this.cbanc.TabIndex = 5;
            this.cbanc.Text = "Anchoas";
            this.cbanc.UseVisualStyleBackColor = true;
            // 
            // cbbac
            // 
            this.cbbac.AutoSize = true;
            this.cbbac.Location = new System.Drawing.Point(27, 49);
            this.cbbac.Name = "cbbac";
            this.cbbac.Size = new System.Drawing.Size(68, 20);
            this.cbbac.TabIndex = 4;
            this.cbbac.Text = "Bacon";
            this.cbbac.UseVisualStyleBackColor = true;
            // 
            // rbgran
            // 
            this.rbgran.AutoSize = true;
            this.rbgran.Location = new System.Drawing.Point(25, 49);
            this.rbgran.Name = "rbgran";
            this.rbgran.Size = new System.Drawing.Size(73, 20);
            this.rbgran.TabIndex = 1;
            this.rbgran.TabStop = true;
            this.rbgran.Text = "Grande";
            this.rbgran.UseVisualStyleBackColor = true;
            // 
            // rbmed
            // 
            this.rbmed.AutoSize = true;
            this.rbmed.Location = new System.Drawing.Point(25, 89);
            this.rbmed.Name = "rbmed";
            this.rbmed.Size = new System.Drawing.Size(81, 20);
            this.rbmed.TabIndex = 2;
            this.rbmed.TabStop = true;
            this.rbmed.Text = "Mediana";
            this.rbmed.UseVisualStyleBackColor = true;
            // 
            // rbpeq
            // 
            this.rbpeq.AutoSize = true;
            this.rbpeq.Location = new System.Drawing.Point(25, 129);
            this.rbpeq.Name = "rbpeq";
            this.rbpeq.Size = new System.Drawing.Size(83, 20);
            this.rbpeq.TabIndex = 3;
            this.rbpeq.TabStop = true;
            this.rbpeq.Text = "Pequeña";
            this.rbpeq.UseVisualStyleBackColor = true;
            // 
            // gbtam
            // 
            this.gbtam.Controls.Add(this.rbpeq);
            this.gbtam.Controls.Add(this.rbgran);
            this.gbtam.Controls.Add(this.rbmed);
            this.gbtam.Location = new System.Drawing.Point(372, 40);
            this.gbtam.Name = "gbtam";
            this.gbtam.Size = new System.Drawing.Size(199, 170);
            this.gbtam.TabIndex = 1;
            this.gbtam.TabStop = false;
            this.gbtam.Text = "Tamaño:";
            // 
            // bttotal
            // 
            this.bttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bttotal.Location = new System.Drawing.Point(93, 232);
            this.bttotal.Name = "bttotal";
            this.bttotal.Size = new System.Drawing.Size(88, 32);
            this.bttotal.TabIndex = 2;
            this.bttotal.Text = "Total";
            this.bttotal.UseVisualStyleBackColor = true;
            this.bttotal.Click += new System.EventHandler(this.bttotal_Click);
            // 
            // lbtot
            // 
            this.lbtot.AutoSize = true;
            this.lbtot.Location = new System.Drawing.Point(93, 290);
            this.lbtot.Name = "lbtot";
            this.lbtot.Size = new System.Drawing.Size(41, 16);
            this.lbtot.TabIndex = 3;
            this.lbtot.Text = "Total:";
            // 
            // lbres
            // 
            this.lbres.AutoSize = true;
            this.lbres.Location = new System.Drawing.Point(199, 290);
            this.lbres.Name = "lbres";
            this.lbres.Size = new System.Drawing.Size(14, 16);
            this.lbres.TabIndex = 4;
            this.lbres.Text = "0";
            // 
            // nudunidad
            // 
            this.nudunidad.Location = new System.Drawing.Point(397, 252);
            this.nudunidad.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudunidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudunidad.Name = "nudunidad";
            this.nudunidad.Size = new System.Drawing.Size(98, 22);
            this.nudunidad.TabIndex = 5;
            this.nudunidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unidades: ";
            // 
            // ejer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudunidad);
            this.Controls.Add(this.lbres);
            this.Controls.Add(this.lbtot);
            this.Controls.Add(this.bttotal);
            this.Controls.Add(this.gbtam);
            this.Controls.Add(this.gbing);
            this.Name = "ejer1";
            this.Text = "ejer1";
            this.Load += new System.EventHandler(this.ejer1_Load);
            this.gbing.ResumeLayout(false);
            this.gbing.PerformLayout();
            this.gbtam.ResumeLayout(false);
            this.gbtam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudunidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbing;
        private System.Windows.Forms.CheckBox cbtomna;
        private System.Windows.Forms.CheckBox cbanc;
        private System.Windows.Forms.CheckBox cbbac;
        private System.Windows.Forms.RadioButton rbgran;
        private System.Windows.Forms.RadioButton rbmed;
        private System.Windows.Forms.RadioButton rbpeq;
        private System.Windows.Forms.GroupBox gbtam;
        private System.Windows.Forms.Button bttotal;
        private System.Windows.Forms.CheckBox cbcebo;
        private System.Windows.Forms.Label lbtot;
        private System.Windows.Forms.Label lbres;
        private System.Windows.Forms.NumericUpDown nudunidad;
        private System.Windows.Forms.Label label1;
    }
}