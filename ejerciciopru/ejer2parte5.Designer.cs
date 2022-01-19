namespace ejerciciopru
{
    partial class ejer2parte5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbresul = new System.Windows.Forms.Label();
            this.chbcomp = new System.Windows.Forms.CheckBox();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.cbtalla = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbexpre = new System.Windows.Forms.RadioButton();
            this.rbcorreo = new System.Windows.Forms.RadioButton();
            this.rbreco = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.nudunid = new System.Windows.Forms.NumericUpDown();
            this.colornegro = new System.Windows.Forms.PictureBox();
            this.colorazul = new System.Windows.Forms.PictureBox();
            this.colorver = new System.Windows.Forms.PictureBox();
            this.colorrojo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbpru = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudunid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colornegro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorazul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorrojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de la compra: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elige talla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(301, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio: ";
            // 
            // lbresul
            // 
            this.lbresul.AutoSize = true;
            this.lbresul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbresul.ForeColor = System.Drawing.Color.Crimson;
            this.lbresul.Location = new System.Drawing.Point(369, 373);
            this.lbresul.Name = "lbresul";
            this.lbresul.Size = new System.Drawing.Size(23, 25);
            this.lbresul.TabIndex = 5;
            this.lbresul.Text = "0";
            // 
            // chbcomp
            // 
            this.chbcomp.AutoSize = true;
            this.chbcomp.Location = new System.Drawing.Point(492, 214);
            this.chbcomp.Name = "chbcomp";
            this.chbcomp.Size = new System.Drawing.Size(102, 20);
            this.chbcomp.TabIndex = 10;
            this.chbcomp.Text = "Compostura";
            this.chbcomp.UseVisualStyleBackColor = true;
            this.chbcomp.CheckedChanged += new System.EventHandler(this.chbcomp_CheckedChanged);
            // 
            // dtfecha
            // 
            this.dtfecha.Location = new System.Drawing.Point(433, 293);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(179, 22);
            this.dtfecha.TabIndex = 11;
            this.dtfecha.ValueChanged += new System.EventHandler(this.dtfecha_ValueChanged);
            // 
            // cbtalla
            // 
            this.cbtalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtalla.FormattingEnabled = true;
            this.cbtalla.Items.AddRange(new object[] {
            "36",
            "38",
            "40",
            "42",
            "44"});
            this.cbtalla.Location = new System.Drawing.Point(632, 97);
            this.cbtalla.Name = "cbtalla";
            this.cbtalla.Size = new System.Drawing.Size(120, 24);
            this.cbtalla.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbexpre);
            this.groupBox1.Controls.Add(this.rbcorreo);
            this.groupBox1.Controls.Add(this.rbreco);
            this.groupBox1.Location = new System.Drawing.Point(632, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 105);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrega:";
            // 
            // rbexpre
            // 
            this.rbexpre.AutoSize = true;
            this.rbexpre.Location = new System.Drawing.Point(17, 79);
            this.rbexpre.Name = "rbexpre";
            this.rbexpre.Size = new System.Drawing.Size(77, 20);
            this.rbexpre.TabIndex = 2;
            this.rbexpre.Text = "Express";
            this.rbexpre.UseVisualStyleBackColor = true;
            this.rbexpre.CheckedChanged += new System.EventHandler(this.rbexpre_CheckedChanged);
            // 
            // rbcorreo
            // 
            this.rbcorreo.AutoSize = true;
            this.rbcorreo.Location = new System.Drawing.Point(17, 53);
            this.rbcorreo.Name = "rbcorreo";
            this.rbcorreo.Size = new System.Drawing.Size(125, 20);
            this.rbcorreo.TabIndex = 1;
            this.rbcorreo.Text = "Correo ordinario";
            this.rbcorreo.UseVisualStyleBackColor = true;
            this.rbcorreo.CheckedChanged += new System.EventHandler(this.rbcorreo_CheckedChanged);
            // 
            // rbreco
            // 
            this.rbreco.AutoSize = true;
            this.rbreco.Checked = true;
            this.rbreco.Location = new System.Drawing.Point(17, 27);
            this.rbreco.Name = "rbreco";
            this.rbreco.Size = new System.Drawing.Size(128, 20);
            this.rbreco.TabIndex = 0;
            this.rbreco.TabStop = true;
            this.rbreco.Text = "Recogida tienda";
            this.rbreco.UseVisualStyleBackColor = true;
            this.rbreco.CheckedChanged += new System.EventHandler(this.rbreco_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unidades:";
            // 
            // nudunid
            // 
            this.nudunid.Location = new System.Drawing.Point(374, 211);
            this.nudunid.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudunid.Name = "nudunid";
            this.nudunid.Size = new System.Drawing.Size(85, 22);
            this.nudunid.TabIndex = 15;
            this.nudunid.ValueChanged += new System.EventHandler(this.nudunid_ValueChanged);
            // 
            // colornegro
            // 
            this.colornegro.Image = global::ejerciciopru.Properties.Resources.colornegro;
            this.colornegro.Location = new System.Drawing.Point(520, 97);
            this.colornegro.Name = "colornegro";
            this.colornegro.Size = new System.Drawing.Size(67, 48);
            this.colornegro.TabIndex = 9;
            this.colornegro.TabStop = false;
            this.colornegro.Click += new System.EventHandler(this.colornegro_Click);
            // 
            // colorazul
            // 
            this.colorazul.Image = global::ejerciciopru.Properties.Resources.colorvazul;
            this.colorazul.Location = new System.Drawing.Point(447, 97);
            this.colorazul.Name = "colorazul";
            this.colorazul.Size = new System.Drawing.Size(67, 48);
            this.colorazul.TabIndex = 8;
            this.colorazul.TabStop = false;
            this.colorazul.Click += new System.EventHandler(this.colorazul_Click);
            // 
            // colorver
            // 
            this.colorver.Image = global::ejerciciopru.Properties.Resources.colorverde;
            this.colorver.Location = new System.Drawing.Point(374, 97);
            this.colorver.Name = "colorver";
            this.colorver.Size = new System.Drawing.Size(67, 48);
            this.colorver.TabIndex = 7;
            this.colorver.TabStop = false;
            this.colorver.Click += new System.EventHandler(this.colorver_Click);
            // 
            // colorrojo
            // 
            this.colorrojo.Image = global::ejerciciopru.Properties.Resources.colorrojo;
            this.colorrojo.Location = new System.Drawing.Point(301, 97);
            this.colorrojo.Name = "colorrojo";
            this.colorrojo.Size = new System.Drawing.Size(67, 48);
            this.colorrojo.TabIndex = 6;
            this.colorrojo.TabStop = false;
            this.colorrojo.Click += new System.EventHandler(this.colorrojo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(603, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Finalizar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbpru
            // 
            this.lbpru.AutoSize = true;
            this.lbpru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbpru.ForeColor = System.Drawing.Color.Coral;
            this.lbpru.Location = new System.Drawing.Point(509, 369);
            this.lbpru.Name = "lbpru";
            this.lbpru.Size = new System.Drawing.Size(27, 29);
            this.lbpru.TabIndex = 17;
            this.lbpru.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(444, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "TOTAL:";
            // 
            // ejer2parte5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbpru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudunid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbtalla);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.chbcomp);
            this.Controls.Add(this.colornegro);
            this.Controls.Add(this.colorazul);
            this.Controls.Add(this.colorver);
            this.Controls.Add(this.colorrojo);
            this.Controls.Add(this.lbresul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ejer2parte5";
            this.Text = "ejer2parte5";
            this.Load += new System.EventHandler(this.ejer2parte5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudunid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colornegro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorazul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorrojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbresul;
        private System.Windows.Forms.PictureBox colorrojo;
        private System.Windows.Forms.PictureBox colorver;
        private System.Windows.Forms.PictureBox colorazul;
        private System.Windows.Forms.PictureBox colornegro;
        private System.Windows.Forms.CheckBox chbcomp;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.ComboBox cbtalla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbexpre;
        private System.Windows.Forms.RadioButton rbcorreo;
        private System.Windows.Forms.RadioButton rbreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudunid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbpru;
        private System.Windows.Forms.Label label6;
    }
}