using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DEVSIS_ENERGISUR
{
    public partial class ActualizarVehiculo : Form
    {
        string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456";
        //string cadena = "Data Source=.;Initial Catalog=Prontiauto;Integrated Security=True";
        //string cadena = "Data Source=CHRISTOPHER;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=leonardo2c";

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
            ValidartextPlaca(cod);
            string consult = "SELECT * FROM VEHICULOS WHERE PLACA =" + "'" + cod + "'";
            SqlCommand comando = new SqlCommand(consult, cn);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textPlaca.Text = registro["PLACA"].ToString();
                textMarca.Text = registro["MARCA"].ToString();
                textModel.Text = registro["MODELO"].ToString();
                textAN.Text = registro["AÑO"].ToString();
                textKm.Text = registro["KILOMETRAJE"].ToString();
                textPC.Text = registro["PRECIO_COMPRA"].ToString();
                textPC.Text = registro["PRECIO_VENTA"].ToString();
                
            }
            else
                MessageBox.Show("Vehiculo no registrado");
            cn.Close();
        }



        private void botonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string cod = textPlaca.Text;
                string descri = textPV.Text;
                ValidartextPV(descri);
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
                {
                    MessageBox.Show("Vehículo no actualizado");
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vehículo no registrado");
            }


        }
        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                mostrar_Click();
            }
        }
        private void botonRegresar_Click_1(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Close();
        }

        private void ValidartextPV(string pv)
        {
            if (v.validarNumeros(pv))
            {

            }
            else if (pv == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de precio de venta vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textPV.Text = "";

                }
                else
                {

                    new ActualizarVehiculo().Show();
                    this.Visible = false;

                }

            }
            
            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Precio de venta inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textPV.Text = "";
                }
                else
                {
                    new ActualizarVehiculo().Show();
                    this.Visible = false;

                }

            }


        }

        private void ValidartextPlaca(string placa)
        {
            if (v.validarPlaca(placa))
            {

            }
            else if (placa == String.Empty)
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

        private void ActualizarVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
