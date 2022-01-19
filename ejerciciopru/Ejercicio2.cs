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
    public partial class Ejercicio2 : Form
    {
        private bool destino = false, tipoviaje = true, fecha = false;
        private const int hotel = 75, excur = 100, alqui=50;
        public Ejercicio2()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            btguarda.Visible = false;

        }

        private void dtinicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtinicio.Value > DateTime.Now)
            {
                fecha = true;
            }
            else { 
            MessageBox.Show("Selecciona la fecha correcta posterior");
            fecha = false;
        }// la pongo otra vez a falso porque en caso de ponerla bien y lugo modificarlo a proposito el valor seria
            //tru por defecto.
        }

        

        private void btguarda_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "png (*.png)| *.png";
            saveFileDialog1.FileName = "reservaQR";
            saveFileDialog1.InitialDirectory = "\\Musica || \\Descargas";
            saveFileDialog1.RestoreDirectory = true;
            if (result == DialogResult.OK) { // DialogResult.OK?
            String ruta = saveFileDialog1.FileName;
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void btreiniciar_Click(object sender, EventArgs e)
        {
            cbdes.SelectedIndex = -1;
            destino = false;
            nudias.Value = 1;
            nudpersonas.Value = 1;
            rbida.Checked = true;
            chbalq.Checked = false;
            cbtodo.Checked = false;
            chbtraspor.Checked = false;
            cbexcursion.Checked=false;
            pictureBox1.Visible = false;
            btguarda.Visible = false;
            dtinicio.Value = DateTime.Now;
            lbpreciofinal.Text = "";
            

        }

        private void rbida_CheckedChanged(object sender, EventArgs e)
        {
            if (rbida.Checked)
                tipoviaje = true;
        }

        private void rbidayvuelta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbidayvuelta.Checked)
                tipoviaje = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbpreciofinal_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbdes_SelectedIndexChanged(object sender, EventArgs e)
        {
            destino = true;
            
        }
        private void btcal_Click(object sender, EventArgs e)
        {
            /*
             * Se puede abreviar solamente seleccionando la opcion checked = true, en uno de los dos radiobutons
             * de esa forma ya hay una opcion seleccionada por defecto.
             */
            if (!destino) {
                MessageBox.Show("Falta el destino");           
            }
            if (!fecha)
            {
                MessageBox.Show("Falta la fecha");
            }
            if (destino && fecha) // el tipo de viaje es obligatorio siempre
            {
                int preciofinal = 0; // variable para acumular todo
                if (rbida.Checked)
                {
                    preciofinal += 300;
                }
                else
                {
                    preciofinal += 550;
                }
                if (cbtodo.Checked)
                {
                    preciofinal += 20 * (int)nudias.Value;
                }
                if (chbtraspor.Checked)
                    preciofinal += hotel;
                if (cbexcursion.Checked)
                    preciofinal += excur;
                if (chbalq.Checked)
                {
                    preciofinal += alqui;
                }
                lbpreciofinal.Text = preciofinal + "€";
                pictureBox1.Visible = true;
                btguarda.Visible=true;
            }
        }
    }
}
