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
    public partial class EliminarVehiculo : Form
    {
        string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
        //string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456";
        SqlCommand cmd;
        SqlDataReader dr;
        public SqlConnection cn = new SqlConnection();
        Validaciones v = new Validaciones();
        public EliminarVehiculo()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }

    
        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Close();
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
                textMarca.Text = registro["MARCA"].ToString();
                textPlaca.Text = registro["PLACA"].ToString();
                textModel.Text = registro["MODELO"].ToString();
                this.comboBox1.Text = registro["TIPO"].ToString();
                textKm.Text = registro["KILOMETRAJE"].ToString();
                textPC.Text = registro["PRECIO_COMPRA"].ToString();
                textPV.Text = registro["PRECIO_VENTA"].ToString();
              
            }
            else
                MessageBox.Show("Vehiculo no registrado");
            cn.Close();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string cod = textPlaca.Text;
            string cadena = "delete VEHICULOS  WHERE PLACA =" + "'" + cod + "'";
            SqlCommand comando = new SqlCommand(cadena, cn);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se eliminó el vehículo correctamente");
                textPV.Text = "";
                new EliminarVehiculo().Show();
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

    }
}
