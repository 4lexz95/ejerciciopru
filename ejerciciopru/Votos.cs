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
    public partial class Votos : Form
    {
        private int cand1 = 0, cand2 = 0, blanco=0, votos;
        private const int numvotos = 24;

        private void btcan1_Click(object sender, EventArgs e)
        {
            if (votos != numvotos)
            {
                cand1++;
                votos++;
                lbvotos.Text = votos.ToString();
            }
            else
            {
                MessageBox.Show("Ya han votado todos");
            }
        }

        private void btcan2_Click(object sender, EventArgs e)
        {
            if (votos != numvotos)
            {
                cand2++;
                votos++;
                lbvotos.Text = votos.ToString();
            }
            else
            {
                MessageBox.Show("Ya han votado todos");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (votos != numvotos)
            {
                blanco++;
                votos++;
                lbvotos.Text = votos.ToString();
            }
            else
            {
                MessageBox.Show("Ya han votado todos");
            }
        }

        private void lbvotos_Click(object sender, EventArgs e)
            {

            }

        private void btreset_Click(object sender, EventArgs e)
        {
            votos = 0;
            cand1 = 0;
            cand2 = 0;
            blanco = 0;
            lbvotos.Text = "";
            txbresul1.Visible = false;
        }

        private void btresul_Click(object sender, EventArgs e)
        {
            if (votos == numvotos)
            {
                txbresul1.Visible = true; ;
                txbresul1.Text = "Candidato 1: " + cand1 + "\n Candidato 2: " + cand2 + "\nBlanco: " + blanco;
            }
            else
            {
                if (votos < 24) {
                    MessageBox.Show("Aun no han votado todos");
                }
            }
        }

        public Votos()
        {
            InitializeComponent();
            txbresul1.Visible=false;
            
        }

        private void Votos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
