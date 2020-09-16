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
    public partial class ActualizarVehiculo : Form
    {
        string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
        SqlCommand cmd;
        SqlDataReader dr;
        public SqlConnection cn = new SqlConnection();
        Validaciones v = new Validaciones();
        public ActualizarVehiculo()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }

        public void mostrar_Click()
        {
            cn.Open();
            string cod = textPlaca.Text;
            string consult = "SELECT * FROM VEHICULOS WHERE PLACA =" + "'" + cod + "'";
            SqlCommand comando = new SqlCommand(consult, cn);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textMarca.Text = registro["MARCA"].ToString();
                textPlaca.Text = registro["PLACA"].ToString();
                textModel.Text = registro["MODELO"].ToString();
                textKm.Text = registro["KILOMETRAJE"].ToString();
                textPC.Text = registro["PRECIO_COMPRA"].ToString();
                textPC.Text = registro["PRECIO_VENTA"].ToString();

            }
            else
                MessageBox.Show("Vehiculo no registrado");
            cn.Close();
        }
        private void ActualizarVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string cod = textPlaca.Text;
            string descri = textPV.Text;
            string cadena = "update VEHICULOS set PRECIO_VENTA=" + descri + " WHERE PLACA =" + "'" + cod + "'";
            SqlCommand comando = new SqlCommand(cadena, cn);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se actualizó el vehículo correctamente");
                textPV.Text = "";
                new ActualizarVehiculo().Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("Vehículo no registrado");
            cn.Close();
        }

        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                mostrar_Click();
            }
        }
        private void textPlaca_Leave(object sender, EventArgs e)
        {
            if (v.validarPlaca(textPlaca.Text))
            {

            }
            else if (textPlaca.Text == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de Placa vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textPlaca.Text = "";

                }
                else
                {

                    new ActualizarVehiculo().Show();
                    this.Visible = false;

                }

            }

            /*else if (vehiculoRegistrado(textPlaca.Text) == 0)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "El Vehículo no se encuentra registrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                    textPlaca.Text = "";
                }
                else
                {
                    new ActualizarVehiculo().Show();
                    this.Visible = false;

                }

            }
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Close();
            
        }
    }
}
