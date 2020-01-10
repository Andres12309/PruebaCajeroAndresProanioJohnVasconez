using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Automatico
{
    public partial class frmDeposito : Form
    {
        public frmDeposito()
        {
            InitializeComponent();
        }

        SqlConnection conectarbd = new SqlConnection("Server=JOVV;Database=CajeroAutomatico;Integrated Security=true");

        public void Depositar(string cantidad)
        {
            try
            {
                conectarbd.Open();
                SqlCommand cmd = new SqlCommand("Insert into Deposito_Retiro(Deposito) values('" + cantidad+"')", conectarbd);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conectarbd.Close();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Depositar(this.TxtDepositar.Text);
            this.Hide();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
