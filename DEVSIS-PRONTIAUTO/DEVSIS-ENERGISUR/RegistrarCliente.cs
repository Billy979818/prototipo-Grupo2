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
    public partial class RegistrarCliente : Form
    {
        //string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
        string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456";
        public SqlConnection cn = new SqlConnection();
        Validaciones v = new Validaciones();
        public RegistrarCliente()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textCI.Text = "";
            textName.Text = "";
            fechaNa.Text = "";
            textDir.Text = "";
            textTC.Text = "";
            textEMAIL.Text = "";
        }

        private void RegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string cod = textCI.Text;
                string name = textName.Text;
                string fn = this.fechaNa.Text;
                string dir = textDir.Text;
                string tc = textTC.Text;
                string mail = textEMAIL.Text;
                string cadena = "insert into CLIENTES(NOMBRES,CEDULA,FECHA_NAC,CELULAR,DIRECCION,EMAIL)values ('" + name + "'," + cod + ",'" + fechaNa.Value.ToString("yyyy-MM-dd") + "','" + tc + "','" + dir + "','" + mail + "')";
                SqlCommand comando = new SqlCommand(cadena, cn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se registro el cliente correctamente");
                buttonLimpiar.Enabled = true;
                cn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Cliente no registrado");
            }
        }

//validaciones
        private void ValidarNombre(object sender, EventArgs e)
        {
            if (v.validarNombre(textName.Text))
            {

            }
            else if (textName.Text == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de Nombres Completos vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textName.Text = "";

                }
                else
                {
                    buttonLimpiar.Enabled = true;
                }

            }
            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Nombres Completos inválidos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textName.Text = "";
                }
                else
                {
                    buttonLimpiar.Enabled = true;

                }

            }


        }

        private void ValidarCedula(object sender, EventArgs e)
        {
            if (v.VerificaCedula(textCI.Text))
            {

            }
            else if (textCI.Text == String.Empty)
            {
                if (MessageBox.Show("Desea repetir el ingreso?", "Entrada de número de cédula de ciudadanía vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textCI.Text = "";
                }
                else
                { 
                    buttonLimpiar.Enabled = true;
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
                    buttonLimpiar.Enabled = true;
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
                    buttonLimpiar.Enabled = true;

                }
            }
        }


        private void ValidarDir(object sender, EventArgs e)
        {
            if (v.validarDireccion(textDir.Text))
            {

            }
            else if (textDir.Text == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de dirección vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textDir.Text = "";

                }
                else
                {
                    buttonLimpiar.Enabled = true;

                }

            }
            else
            {
                if (MessageBox.Show("Desea repetir el ingreso?", "Dirección inválida", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textDir.Text = "";
                }
                else
                {
                    buttonLimpiar.Enabled = true;

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
                    buttonLimpiar.Enabled = true;

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
                    buttonLimpiar.Enabled = true;
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
                    buttonLimpiar.Enabled = true;
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
                    buttonLimpiar.Enabled = true;
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
                    buttonLimpiar.Enabled = true;

                }
            }
        }




    }
}
