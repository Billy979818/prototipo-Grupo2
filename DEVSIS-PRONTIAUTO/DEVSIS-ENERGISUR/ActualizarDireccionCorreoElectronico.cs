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
    public partial class ActualizarDireccionCorreoElectronico : Form
    {
        string cadena = "Data Source=.;Initial Catalog=Prontiauto;Integrated Security=True";
        //string cadena = "Data Source=CHRISTOPHER;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=leonardo2c";
        // string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456";
        public SqlConnection cn = new SqlConnection();
        Validaciones v = new Validaciones();
        public ActualizarDireccionCorreoElectronico()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }

        private void labelIngresarProducto_Click(object sender, EventArgs e)
        {

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
                string descri = textEMAIL.Text;
                string cadena = "update CLIENTES set EMAIL='" + descri + "' where CEDULA=" + cod;
                SqlCommand comando = new SqlCommand(cadena, cn);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se actualizó la dirección de correo electrónico del cliente correctamente");
                    textEMAIL.Text = "";
                    new ActualizarDireccionCorreoElectronico().Show();
                    this.Visible = false;
                }
                else {
                    MessageBox.Show("La dirección de correo electrónico del cliente no ha sido actualizada");
                    textEMAIL.Text = "";
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
                if (MessageBox.Show("Desea repetir el ingreso?", "Entrada de número de cédula de ciudadanía vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textCI.Text = "";
                }
                else
                {

                    new ActualizarDireccionCorreoElectronico().Show();
                    this.Visible = false;

                }

            }
            else if (textCI.TextLength < 10)
            {
                if (MessageBox.Show("Desea repetir el ingreso?", "Número de cédula de ciudadanía inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textCI.Text = "";
                }
                else
                {
                    new ActualizarDireccionCorreoElectronico().Show();
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

                    new ActualizarDireccionCorreoElectronico().Show();
                    this.Visible = false;

                }

            }


        }



        private void ValidarEmail(object sender, EventArgs e)
        {
            if (v.validarEmail(textEMAIL.Text))
            {

            }
            else if (textEMAIL.Text == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de dirección de correo electrónico vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textEMAIL.Text = "";

                }
                else
                {

                    new ActualizarDireccionCliente().Show();
                    this.Visible = false;

                }

            }
            else
            {
                if (MessageBox.Show("Desea repetir el ingreso?", "Dirección de correo electrónico inválida", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textEMAIL.Text = "";
                }
                else
                {

                    new ActualizarDireccionCliente().Show();
                    this.Visible = false;

                }

            }


        }

        private void ActualizarDireccionCorreoElectronico_Load(object sender, EventArgs e)
        {

        }
    }
}
