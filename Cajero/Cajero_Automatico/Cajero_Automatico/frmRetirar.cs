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
    public partial class frmRetirar : Form
    {
        public frmRetirar()
        {
            InitializeComponent();
        }
        SqlConnection conectarbd = new SqlConnection("Server=JOVV;Database=CajeroAutomatico;Integrated Security=true");

        public void inserta10(string cantidad)
        {
            try
            {
                conectarbd.Open();
                SqlCommand cmd = new SqlCommand("Insert into Deposito_Retiro(Retiro) values('" + cantidad+ "')",conectarbd);
                cmd.ExecuteNonQuery();
              
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);

                /*if (dt.Rows.Count == 1)
                {
                    //this.Hide();
                    if (dt.Rows[0][2].ToString() == "1600731176")
                    {
                        new frmCajero(dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString()).Show();

                    }
                    else if (dt.Rows[0][2].ToString() == "1723157887")
                    {
                        new frmCajero(dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");
                }*/

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
        public void inserta20(string cantidad)
        {
            try
            {
                conectarbd.Open();
                SqlCommand cmd = new SqlCommand("Insert into Deposito_Retiro(Retiro) value('" + cantidad + "')", conectarbd);
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
        private void Rbtn10_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
