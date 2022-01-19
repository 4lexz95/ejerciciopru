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
    public partial class ejer1 : Form
    {
        
        public ejer1()
        {
            InitializeComponent();
            rbgran.Checked = true;
        }

        private void bttotal_Click(object sender, EventArgs e)
        {
            float precio = 0;
            if (rbmed.Checked)
                precio += 9;
            if (rbpeq.Checked)
                precio += 7;
            if (rbgran.Checked)
                precio += 11;
            if (cbbac.Checked)
                precio += 1.50f;
            if(cbanc.Checked)
                precio += 1.80f;
            if (cbcebo.Checked)
                precio += 1.00f;
            if (cbtomna.Checked)
            {
                precio += 1.20f;
            }
            precio *= (int)nudunidad.Value;
            lbres.Text = precio.ToString();

        }

        private void ejer1_Load(object sender, EventArgs e)
        {

        }
    }
}
