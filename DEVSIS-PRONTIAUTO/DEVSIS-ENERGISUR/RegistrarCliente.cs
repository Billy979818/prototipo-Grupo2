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
        //string cadena = "Data Source=CHRISTOPHER;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=leonardo2c";
        // string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456";
        string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";

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
            DialogResult opcion;
             if (textName.Text.Length>4)
            {
                textCI.Enabled = true;
            }
            else if (textName.Text.Length>80)
            {
                opcion = MessageBox.Show("Nombre invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (opcion == DialogResult.OK)
                {
                    opcion = MessageBox.Show("Desea repetir el ingreso", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcion == DialogResult.Yes)
                    {
                        textName.Text = " ";
                    }
                    else
                    {
                        new MenuPrincipal().Show();
                        this.Visible = false;
                    }

                }
                else
                {
                    new MenuPrincipal().Show();
                    this.Visible = false;
                }

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
                
                textCI.Enabled = true;
            }
            

        }

        private void ValidarCedula(object sender, EventArgs e)
        {
           
        }


        private void ValidarDir(object sender, EventArgs e)
        {
           
        }

        private void ValidarEmail(object sender, EventArgs e)
        {
            
        }

        private void ValidarCelular(object sender, EventArgs e)
        {
            
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCI_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Nombres(e);
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void textEMAIL_Leave(object sender, EventArgs e)
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

        private void textTC_Leave(object sender, EventArgs e)
        {
            if (v.validarNumeros(textTC.Text))
            {
                textDir.Enabled = true;
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
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Teléfono inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            textDir.Enabled = true;

        }

        private void textTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDir_Leave(object sender, EventArgs e)
        {
            if (v.validarDireccion(textDir.Text))
            {
                textEMAIL.Enabled = true;
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
            textEMAIL.Enabled = true;

        }

        private void RegistrarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void RegistrarCliente_Leave(object sender, EventArgs e)
        {

        }

        private void textCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        private void textCI_Leave(object sender, EventArgs e)
        {
            if (v.VerificaCedula(textCI.Text))
            {
                fechaNa.Enabled = true;
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
                fechaNa.Enabled = true;
            }
            fechaNa.Enabled = true;
        }
    }
}
