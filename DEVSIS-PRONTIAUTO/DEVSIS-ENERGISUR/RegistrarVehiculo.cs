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

namespace DEVSIS_ENERGISUR
{
    public partial class RegistrarVehiculo : Form
    {
        string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
        SqlCommand cmd;
        SqlDataReader dr;
        public SqlConnection cn = new SqlConnection();
        Validaciones v = new Validaciones();
        public RegistrarVehiculo()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }

        public void limpiarCampos()
        {
            txtMarca.Text = "";
            txtPlaca.Text = "";
            comboBox1.Enabled = false;
            txtModelo.Text = "";
            txt_kilometraje.Text = "";
            txtPV.Text = "";
            txtPC.Text = "";
        }
        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Close();
        }

        private void txtprecioVen_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string m = txtMarca.Text;
                string p = txtPlaca.Text;
                string t = this.comboBox1.Text;
                string mod = txtModelo.Text;
                string km = txt_kilometraje.Text;
                string pc = txtPC.Text;
                string pv = txtPV.Text;

                string cadena = "insert into VEHICULOS(MARCA,PLACA,TIPO,MODELO,KILOMETRAJE,PRECIO_COMPRA,PRECIO_VENTA)values ('" + m + "','" + p + "','" + t + "','" + mod + "'," + km + "," + pc + "," + pv + ")";
                SqlCommand comando = new SqlCommand(cadena, cn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se registro el vehículo correctamente");
                bt_limpiar.Enabled = true;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            if (v.validarPlaca(txtPlaca.Text))
            {

            }
            else if (txtPlaca.Text == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de Placa vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtPlaca.Text = "";

                }
                else
                {

                    //new ActualizarVehiculo().Show();
                    //this.Visible = false;

                }

            }
            else if (txtPlaca.TextLength < 8)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Placa inválida", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtPlaca.Text = "";
                }
                else
                {
                    //new ActualizarVehiculo().Show();
                    //this.Visible = false;

                }
            }
            /*else if (vehiculoRegistrado(textPlaca.Text)<0)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "El vehículo ya se encuentra registrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textPlaca.Text = "";
                }
                else
                {
                    new ConsultarVehículo().Show();
                    this.Visible = false;
                }
            }*/
            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Placa inválida", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtPlaca.Text = "";
                }
                else
                {
                    //new ActualizarVehiculo().Show();
                    //this.Visible = false;

                }

            }
        }
    }
}
