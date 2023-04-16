using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_VarYSec_Ejercicio4
{
    public partial class fArchivo : Form
    {
        public fArchivo()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bGigaBytes_Click(object sender, EventArgs e)
        {
            string archivo = tArchivo.Text;
            double megas = Convert.ToDouble(tTamaño.Text);
            double gigas = megas / 1024;
            MessageBox.Show("El archivo " + archivo + " pesa " + gigas + " Gb");
        }
    }
}
