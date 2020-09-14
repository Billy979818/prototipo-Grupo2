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
        string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto; Integrated Security=True";
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
            dateTimefn.Text = "";
            textDir.Text = "";
            textTC.Text = "";
            textEMAIL.Text = "";
        }

        private void RegistrarCliente_Click(object sender, EventArgs e)
        {
            cn.Open();
            string cod = textCI.Text;
            string name = textName.Text;
            string fn = dateTimefn.Text;
            string dir = textDir.Text;
            string tc = textTC.Text;
            string mail = textEMAIL.Text;
            string cadena = "insert into CLIENTES(NOMBRES,CEDULA,FECHA_NAC,CELULAR,DIRECCION,EMAIL)values ('" + name + "'," + cod + ",'" + fn + "','" + tc + "','" + dir + "','" + mail + "')";
            SqlCommand comando = new SqlCommand(cadena, cn);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se registro el cliente correctamente");
            buttonLimpiar.Enabled = true;
            cn.Close();
           
        }
        private void textCedula_Leave(object sender, EventArgs e)
        {
            if (v.VerificaCedula(textCI.Text))
            {

            }
            else if (textCI.Text == String.Empty)
            {
                if (MessageBox.Show("Desea repetir el ingreso?", "Entrada de número de cédula de ciudadanía vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textCI.Text = "";
                    textCI.Enabled = true;
                }
                else
                {

                    new MenuPrincipal().Show();
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

                    new MenuPrincipal().Show();
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

                    new MenuPrincipal().Show();
                    this.Visible = false;

                }

            }


        }
    }
}
