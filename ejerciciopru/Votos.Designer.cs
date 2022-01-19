namespace ejerciciopru
{
    partial class Votos
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
            this.btcan1 = new System.Windows.Forms.Button();
            this.btcan2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.txbresul1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btresul = new System.Windows.Forms.Button();
            this.lbvotos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btcan1
            // 
            this.btcan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btcan1.Location = new System.Drawing.Point(125, 74);
            this.btcan1.Name = "btcan1";
            this.btcan1.Size = new System.Drawing.Size(162, 46);
            this.btcan1.TabIndex = 0;
            this.btcan1.Text = "Candidato 1";
            this.btcan1.UseVisualStyleBackColor = true;
            this.btcan1.Click += new System.EventHandler(this.btcan1_Click);
            // 
            // btcan2
            // 
            this.btcan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btcan2.Location = new System.Drawing.Point(327, 74);
            this.btcan2.Name = "btcan2";
            this.btcan2.Size = new System.Drawing.Size(159, 46);
            this.btcan2.TabIndex = 1;
            this.btcan2.Text = "Candidato 2";
            this.btcan2.UseVisualStyleBackColor = true;
            this.btcan2.Click += new System.EventHandler(this.btcan2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(518, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Voto en blanco";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(354, 380);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 24);
            this.btreset.TabIndex = 5;
            this.btreset.Text = "Reiniciar";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // txbresul1
            // 
            this.txbresul1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txbresul1.Location = new System.Drawing.Point(191, 297);
            this.txbresul1.Multiline = true;
            this.txbresul1.Name = "txbresul1";
            this.txbresul1.ReadOnly = true;
            this.txbresul1.Size = new System.Drawing.Size(133, 73);
            this.txbresul1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Votaciones realizadas";
            // 
            // btresul
            // 
            this.btresul.Location = new System.Drawing.Point(74, 299);
            this.btresul.Name = "btresul";
            this.btresul.Size = new System.Drawing.Size(93, 23);
            this.btresul.TabIndex = 8;
            this.btresul.Text = "Resultado";
            this.btresul.UseVisualStyleBackColor = true;
            this.btresul.Click += new System.EventHandler(this.btresul_Click);
            // 
            // lbvotos
            // 
            this.lbvotos.AutoSize = true;
            this.lbvotos.Location = new System.Drawing.Point(191, 250);
            this.lbvotos.Name = "lbvotos";
            this.lbvotos.Size = new System.Drawing.Size(14, 16);
            this.lbvotos.TabIndex = 9;
            this.lbvotos.Text = "0";
            this.lbvotos.Click += new System.EventHandler(this.lbvotos_Click);
            // 
            // Votos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbvotos);
            this.Controls.Add(this.btresul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbresul1);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btcan2);
            this.Controls.Add(this.btcan1);
            this.Name = "Votos";
            this.Text = "Votos";
            this.Load += new System.EventHandler(this.Votos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcan1;
        private System.Windows.Forms.Button btcan2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.TextBox txbresul1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btresul;
        private System.Windows.Forms.Label lbvotos;
    }
}