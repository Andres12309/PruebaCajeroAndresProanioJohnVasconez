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
    public partial class frmLoginTargeta : Form
    {
        public frmLoginTargeta()
        {
            InitializeComponent();
            InitializeMyControl();
        }
        private void InitializeMyControl()
        {
            TxtPinTrj.Text = "";
            TxtPinTrj.PasswordChar = '*';
            TxtPinTrj.MaxLength = 4;
        }
        SqlConnection conectarbd = new SqlConnection("Server=JOVV;Database=CajeroAutomatico;Integrated Security=true");
        public void login(string tarjeta, string pin)
        {
            try
            {
                conectarbd.Open();
                SqlCommand cmd = new SqlCommand("SELECT NombreCliente,ApellidoCliente,CedulaCliente, PassCliente FROM Clientes WHERE CedulaCliente = @cedula_cliente AND PassCliente = @pass_cliente", conectarbd);
                cmd.Parameters.AddWithValue("cedula_cliente", tarjeta);
                cmd.Parameters.AddWithValue("pass_cliente", pin);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {                   
                    //this.Hide();
                    if(dt.Rows[0][2].ToString() == "1600731176")
                    {
                        new frmCajero(dt.Rows[0][0].ToString()+" "+dt.Rows[0][1].ToString()).Show();

                    }else if(dt.Rows[0][2].ToString() == "1723157887")
                    {
                        new frmCajero(dt.Rows[0][0].ToString()+" "+dt.Rows[0][1].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");
                }

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
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            login(this.TxtNumeroTrj.Text, this.TxtPinTrj.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
