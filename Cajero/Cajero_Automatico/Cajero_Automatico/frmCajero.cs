using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Automatico
{
    public partial class frmCajero : Form
    {
        public frmCajero(string nombre)
        {
            InitializeComponent();
            LblCliente.Text = nombre;
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            frmRetirar from = new frmRetirar();
            from.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDeposito from = new frmDeposito();
            from.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
