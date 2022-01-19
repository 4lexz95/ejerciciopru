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
   
    public partial class ejer2parte5 : Form
    {
        private int precio, coro=75, cove=80,coaz=85,cone=90, control;
        private bool colroj = false, colver = false, colazu = false, colneg = false;
        
        public ejer2parte5()
        {
            InitializeComponent();
        }

        private void ejer2parte5_Load(object sender, EventArgs e)
        {

        }

        private void colorrojo_Click(object sender, EventArgs e)
        {
            precio = 0;
            chbcomp.Checked = false;
            colroj = true;
            if (colroj)
            {
                precio = coro;
                pictureBox1.Image = Properties.Resources.rojo;
                colver = false;
                colneg = false;
                colazu = false;
                lbresul.Text = precio.ToString() + "€";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void colorver_Click(object sender, EventArgs e)
        {
            precio = 0;
            nudunid.Value = 0;
            chbcomp.Checked = false;
            colver = true;
            if (colver)
            {
                precio = cove;
                pictureBox1.Image = Properties.Resources.verde;
                colroj = false;
                colneg = false;
                colazu = false;
                lbresul.Text = precio.ToString() + "€";
            }
          
        }

        private void colorazul_Click(object sender, EventArgs e)
        {
            precio = 0;
            nudunid.Value=0;
            chbcomp.Checked = false;           
            colazu = true;
            if (colazu)
            {
                precio = coaz;
                pictureBox1.Image = Properties.Resources.azul;
                colroj = false;
                colneg = false;
                colver = false;
                lbresul.Text = precio.ToString() + "€";
            }
        }

        private void colornegro_Click(object sender, EventArgs e)
        {
            precio = 0;
            nudunid.Value = 0;
            chbcomp.Checked = false;
            colneg = true;
            if (colneg)
            {
                precio = cone;
                pictureBox1.Image = Properties.Resources.negro;
                colroj = false;
                colver = false;
                colazu = false;
                lbresul.Text = precio.ToString() + "€";
            }
        }

        private void nudunid_ValueChanged(object sender, EventArgs e)
        {
            int preciofin = 0;

            if (!colroj && !colver && !colneg && !colazu) {
                MessageBox.Show("Elige primero color");
            }
            
            
            preciofin  =  precio * (int)nudunid.Value;
            lbpru.Text = preciofin.ToString();
            lbresul.Text = precio.ToString() + "€";
           
        }

        private void chbcomp_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbcomp.Checked)
            {
                precio += 10;
                lbresul.Text = precio.ToString() +"€";
            }
            else { 
            precio -= 10;
                lbresul.Text = precio.ToString() + "€";
               nudunid.Value = 0;
            }
            
        } 

        private void rbcorreo_CheckedChanged(object sender, EventArgs e)
        {
            precio += 5;
            MessageBox.Show("La entrega se hara en 10 dias laborales.");
            lbresul.Text = precio.ToString() + "€";
        }

        private void rbreco_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbexpre_CheckedChanged(object sender, EventArgs e)
        {
            
                precio += 15;
                MessageBox.Show("La entrega se hara en 24 horas laborales.");
                lbresul.Text = precio.ToString() + "€";
                
        }

        private void dtfecha_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbtalla.SelectedIndex != -1 && rbcorreo.Checked || rbexpre.Checked || rbreco.Checked)
            {
                if (nudunid.Value != 0 )
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Revisa las opciones");
                }
            }
            else
            {
                MessageBox.Show("Revisa las opciones");
            }
                 
            
        }
    }
}
