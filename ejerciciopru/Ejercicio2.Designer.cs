namespace ejerciciopru
{
    partial class Ejercicio2
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
            this.lbdes = new System.Windows.Forms.Label();
            this.lbper = new System.Windows.Forms.Label();
            this.cbdes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbpreciofinal = new System.Windows.Forms.Label();
            this.nudpersonas = new System.Windows.Forms.NumericUpDown();
            this.nudias = new System.Windows.Forms.NumericUpDown();
            this.gbtipo = new System.Windows.Forms.GroupBox();
            this.rbidayvuelta = new System.Windows.Forms.RadioButton();
            this.rbida = new System.Windows.Forms.RadioButton();
            this.gbex = new System.Windows.Forms.GroupBox();
            this.cbtodo = new System.Windows.Forms.CheckBox();
            this.chbalq = new System.Windows.Forms.CheckBox();
            this.cbexcursion = new System.Windows.Forms.CheckBox();
            this.chbtraspor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btcal = new System.Windows.Forms.Button();
            this.btreiniciar = new System.Windows.Forms.Button();
            this.btguarda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtinicio = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudpersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudias)).BeginInit();
            this.gbtipo.SuspendLayout();
            this.gbex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbdes
            // 
            this.lbdes.AutoSize = true;
            this.lbdes.Location = new System.Drawing.Point(59, 34);
            this.lbdes.Name = "lbdes";
            this.lbdes.Size = new System.Drawing.Size(56, 16);
            this.lbdes.TabIndex = 0;
            this.lbdes.Text = "Destino:";
            // 
            // lbper
            // 
            this.lbper.AutoSize = true;
            this.lbper.Location = new System.Drawing.Point(528, 42);
            this.lbper.Name = "lbper";
            this.lbper.Size = new System.Drawing.Size(68, 16);
            this.lbper.TabIndex = 1;
            this.lbper.Text = "Personas:";
            // 
            // cbdes
            // 
            this.cbdes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdes.FormattingEnabled = true;
            this.cbdes.Items.AddRange(new object[] {
            "Paris",
            "Londres",
            "Roma"});
            this.cbdes.Location = new System.Drawing.Point(141, 34);
            this.cbdes.Name = "cbdes";
            this.cbdes.Size = new System.Drawing.Size(170, 24);
            this.cbdes.TabIndex = 2;
            this.cbdes.SelectedIndexChanged += new System.EventHandler(this.cbdes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "dias";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio final:";
            // 
            // lbpreciofinal
            // 
            this.lbpreciofinal.AutoSize = true;
            this.lbpreciofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbpreciofinal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbpreciofinal.Location = new System.Drawing.Point(367, 344);
            this.lbpreciofinal.Name = "lbpreciofinal";
            this.lbpreciofinal.Size = new System.Drawing.Size(27, 29);
            this.lbpreciofinal.TabIndex = 7;
            this.lbpreciofinal.Text = "0";
            this.lbpreciofinal.Click += new System.EventHandler(this.lbpreciofinal_Click);
            // 
            // nudpersonas
            // 
            this.nudpersonas.Location = new System.Drawing.Point(615, 42);
            this.nudpersonas.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudpersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudpersonas.Name = "nudpersonas";
            this.nudpersonas.Size = new System.Drawing.Size(120, 22);
            this.nudpersonas.TabIndex = 8;
            this.nudpersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudias
            // 
            this.nudias.Location = new System.Drawing.Point(615, 95);
            this.nudias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudias.Name = "nudias";
            this.nudias.Size = new System.Drawing.Size(120, 22);
            this.nudias.TabIndex = 9;
            this.nudias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbtipo
            // 
            this.gbtipo.Controls.Add(this.rbidayvuelta);
            this.gbtipo.Controls.Add(this.rbida);
            this.gbtipo.Location = new System.Drawing.Point(70, 167);
            this.gbtipo.Name = "gbtipo";
            this.gbtipo.Size = new System.Drawing.Size(217, 144);
            this.gbtipo.TabIndex = 10;
            this.gbtipo.TabStop = false;
            this.gbtipo.Text = "Tipo de viaje";
            // 
            // rbidayvuelta
            // 
            this.rbidayvuelta.AutoSize = true;
            this.rbidayvuelta.Location = new System.Drawing.Point(16, 79);
            this.rbidayvuelta.Name = "rbidayvuelta";
            this.rbidayvuelta.Size = new System.Drawing.Size(98, 20);
            this.rbidayvuelta.TabIndex = 1;
            this.rbidayvuelta.TabStop = true;
            this.rbidayvuelta.Text = "Ida y Vuelta";
            this.rbidayvuelta.UseVisualStyleBackColor = true;
            this.rbidayvuelta.CheckedChanged += new System.EventHandler(this.rbidayvuelta_CheckedChanged);
            // 
            // rbida
            // 
            this.rbida.AutoSize = true;
            this.rbida.Checked = true;
            this.rbida.Location = new System.Drawing.Point(16, 42);
            this.rbida.Name = "rbida";
            this.rbida.Size = new System.Drawing.Size(78, 20);
            this.rbida.TabIndex = 0;
            this.rbida.TabStop = true;
            this.rbida.Text = "Solo Ida";
            this.rbida.UseVisualStyleBackColor = true;
            this.rbida.CheckedChanged += new System.EventHandler(this.rbida_CheckedChanged);
            // 
            // gbex
            // 
            this.gbex.Controls.Add(this.cbtodo);
            this.gbex.Controls.Add(this.chbalq);
            this.gbex.Controls.Add(this.cbexcursion);
            this.gbex.Controls.Add(this.chbtraspor);
            this.gbex.Location = new System.Drawing.Point(426, 167);
            this.gbex.Name = "gbex";
            this.gbex.Size = new System.Drawing.Size(300, 144);
            this.gbex.TabIndex = 11;
            this.gbex.TabStop = false;
            this.gbex.Text = "Extras:";
            // 
            // cbtodo
            // 
            this.cbtodo.AutoSize = true;
            this.cbtodo.Location = new System.Drawing.Point(163, 90);
            this.cbtodo.Name = "cbtodo";
            this.cbtodo.Size = new System.Drawing.Size(88, 20);
            this.cbtodo.TabIndex = 3;
            this.cbtodo.Text = "Todo incl.";
            this.cbtodo.UseVisualStyleBackColor = true;
            this.cbtodo.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chbalq
            // 
            this.chbalq.AutoSize = true;
            this.chbalq.Location = new System.Drawing.Point(161, 42);
            this.chbalq.Name = "chbalq";
            this.chbalq.Size = new System.Drawing.Size(133, 20);
            this.chbalq.TabIndex = 2;
            this.chbalq.Text = "Alquiler de coche";
            this.chbalq.UseVisualStyleBackColor = true;
            // 
            // cbexcursion
            // 
            this.cbexcursion.AutoSize = true;
            this.cbexcursion.Location = new System.Drawing.Point(23, 90);
            this.cbexcursion.Name = "cbexcursion";
            this.cbexcursion.Size = new System.Drawing.Size(134, 20);
            this.cbexcursion.TabIndex = 1;
            this.cbexcursion.Text = "Excursion Guiada";
            this.cbexcursion.UseVisualStyleBackColor = true;
            // 
            // chbtraspor
            // 
            this.chbtraspor.AutoSize = true;
            this.chbtraspor.Location = new System.Drawing.Point(26, 42);
            this.chbtraspor.Name = "chbtraspor";
            this.chbtraspor.Size = new System.Drawing.Size(126, 20);
            this.chbtraspor.TabIndex = 0;
            this.chbtraspor.Text = "Translado Hotel";
            this.chbtraspor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha Inicio";
            // 
            // btcal
            // 
            this.btcal.Location = new System.Drawing.Point(86, 348);
            this.btcal.Name = "btcal";
            this.btcal.Size = new System.Drawing.Size(75, 23);
            this.btcal.TabIndex = 13;
            this.btcal.Text = "Calcular";
            this.btcal.UseVisualStyleBackColor = true;
            this.btcal.Click += new System.EventHandler(this.btcal_Click);
            // 
            // btreiniciar
            // 
            this.btreiniciar.Location = new System.Drawing.Point(86, 391);
            this.btreiniciar.Name = "btreiniciar";
            this.btreiniciar.Size = new System.Drawing.Size(75, 23);
            this.btreiniciar.TabIndex = 14;
            this.btreiniciar.Text = "Reiniciar";
            this.btreiniciar.UseVisualStyleBackColor = true;
            this.btreiniciar.Click += new System.EventHandler(this.btreiniciar_Click);
            // 
            // btguarda
            // 
            this.btguarda.Location = new System.Drawing.Point(461, 365);
            this.btguarda.Name = "btguarda";
            this.btguarda.Size = new System.Drawing.Size(117, 32);
            this.btguarda.TabIndex = 15;
            this.btguarda.Text = "Guardar";
            this.btguarda.UseVisualStyleBackColor = true;
            this.btguarda.Click += new System.EventHandler(this.btguarda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ejerciciopru.Properties.Resources._5faa727a54ec2__1_;
            this.pictureBox1.Location = new System.Drawing.Point(592, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dtinicio
            // 
            this.dtinicio.Location = new System.Drawing.Point(153, 92);
            this.dtinicio.MinDate = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Size = new System.Drawing.Size(208, 22);
            this.dtinicio.TabIndex = 17;
            this.dtinicio.ValueChanged += new System.EventHandler(this.dtinicio_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.dtinicio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btguarda);
            this.Controls.Add(this.btreiniciar);
            this.Controls.Add(this.btcal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbex);
            this.Controls.Add(this.gbtipo);
            this.Controls.Add(this.nudias);
            this.Controls.Add(this.nudpersonas);
            this.Controls.Add(this.lbpreciofinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbdes);
            this.Controls.Add(this.lbper);
            this.Controls.Add(this.lbdes);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.nudpersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudias)).EndInit();
            this.gbtipo.ResumeLayout(false);
            this.gbtipo.PerformLayout();
            this.gbex.ResumeLayout(false);
            this.gbex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdes;
        private System.Windows.Forms.Label lbper;
        private System.Windows.Forms.ComboBox cbdes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbpreciofinal;
        private System.Windows.Forms.NumericUpDown nudpersonas;
        private System.Windows.Forms.NumericUpDown nudias;
        private System.Windows.Forms.GroupBox gbtipo;
        private System.Windows.Forms.GroupBox gbex;
        private System.Windows.Forms.RadioButton rbidayvuelta;
        private System.Windows.Forms.RadioButton rbida;
        private System.Windows.Forms.CheckBox cbtodo;
        private System.Windows.Forms.CheckBox chbalq;
        private System.Windows.Forms.CheckBox cbexcursion;
        private System.Windows.Forms.CheckBox chbtraspor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btcal;
        private System.Windows.Forms.Button btreiniciar;
        private System.Windows.Forms.Button btguarda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtinicio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}