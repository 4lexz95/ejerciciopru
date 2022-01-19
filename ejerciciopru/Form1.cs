using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciopru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejer1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejer1 ventana = new ejer1();
            ventana.Show();
            ventana.MdiParent = this;
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2 ventana = new Ejercicio2();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void votosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Votos ventana = new Votos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void ejer2parte5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejer2parte5 ventana = new ejer2parte5();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
