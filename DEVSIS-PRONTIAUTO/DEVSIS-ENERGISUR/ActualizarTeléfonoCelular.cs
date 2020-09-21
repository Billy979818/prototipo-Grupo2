using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class ActualizarTeléfonoCelular : Form
    {
        string cadena = "Data Source=.;Initial Catalog=Prontiauto;Integrated Security=True";
        //string cadena = "Data Source=CHRISTOPHER;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=leonardo2c";
        //string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456";
        public SqlConnection cn = new SqlConnection();
        Validaciones v = new Validaciones();
        public ActualizarTeléfonoCelular()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }

       
        private void mostrar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string cod = textCI.Text;
            ValidartextCedula(cod);
            string consult = "select * from CLIENTES where CEDULA=" + cod;
            SqlCommand comando = new SqlCommand(consult, cn);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textCI.Text = registro["CEDULA"].ToString();
                textName.Text = registro["NOMBRES"].ToString();
                textFN.Text = registro["FECHA_NAC"].ToString();
                textTC.Text = registro["CELULAR"].ToString();
                textDir.Text = registro["DIRECCION"].ToString();
                textEMAIL.Text = registro["EMAIL"].ToString();
                buttonMostrar.Enabled = true;
            }
            else
                MessageBox.Show("Cliente no registrado");
            cn.Close();
        }

        //1722484753
        private void botonActualizar_Click(object sender, EventArgs e)
        {
           
                cn.Open();
                string cod = textCI.Text;
                string descri = textTC.Text;
                string cadena = "update CLIENTES set CELULAR='" + descri + "' where CEDULA=" + cod;
                SqlCommand comando = new SqlCommand(cadena, cn);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se actualizó el teléfono celular del cliente correctamente");
                    textTC.Text = "";
                    new ActualizarTeléfonoCelular().Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("El teléfono celular del cliente no ha sido actualizado");
                    textTC.Text = "";
                    cn.Close();
                }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }


        private void ValidartextCedula(string cedula)
        {
            if (v.VerificaCedula(cedula))
            {

            }
            else if (cedula == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de número de cédula de ciudadanía vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textCI.Text = "";
                }
                else
                {

                    new ActualizarTeléfonoCelular().Show();
                    this.Visible = false;

                }

            }
            else if (textCI.TextLength < 10)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Número de cédula de ciudadanía inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textCI.Text = "";
                }
                else
                {
                    new ActualizarTeléfonoCelular().Show();
                    this.Visible = false;

                }
            }
            else
            {
                if (MessageBox.Show("Desea repetir el ingreso?", "Número de cédula de ciudadanía inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textCI.Text = "";
                }
                else
                {

                    new ActualizarTeléfonoCelular().Show();
                    this.Visible = false;

                }

            }


        }



        private void ValidarCelular(object sender, EventArgs e)
        {
            if (v.validarNumeros(textTC.Text))
            {

            }
            else if (textTC.Text == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de teléfono celular vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textTC.Text = "";

                }
                else
                {

                    new ActualizarTeléfonoCelular().Show();
                    this.Visible = false;

                }

            }
            else if (textTC.TextLength < 10)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Teléfono celular inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textTC.Text = "";
                }
                else
                {
                    new ActualizarTeléfonoCelular().Show();
                    this.Visible = false;

                }
            }
            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Teléfono celular inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textTC.Text = "";
                }
                else
                {

                    new ActualizarTeléfonoCelular().Show();
                    this.Visible = false;

                }

            }


        }

        private void ActualizarTeléfonoCelular_Load(object sender, EventArgs e)
        {

        }
    }
}
