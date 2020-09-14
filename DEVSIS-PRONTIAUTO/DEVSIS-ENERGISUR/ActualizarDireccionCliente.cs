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
    public partial class ActualizarDireccionCliente : Form
    {
        string cadena = "Data Source=CHRISTOPHER;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=leonardo2c";
        public SqlConnection cn = new SqlConnection();
        Validaciones v = new Validaciones();
        public ActualizarDireccionCliente()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }

       
        private void labelCodigo_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        private void mostrar_Click(object sender, EventArgs e)
        {
            cn.Open();
            Console.WriteLine("Conexion Exitosa");
            string cod = textCI.Text;
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
            string descri = textDir.Text;
            string cadena = "update CLIENTES set DIRECCION='" + descri + "' where CEDULA=" + cod;
            SqlCommand comando = new SqlCommand(cadena, cn);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se actualizó la dirección del cliente correctamente");
                textDir.Text = "";
                new MenuPrincipal().Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("Cliente no registrado");
            cn.Close();
            botonActualizar.Enabled = false;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

      
            private void textCedula_Leave(object sender, EventArgs e){
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



        /*private void textDir_Leave(object sender, EventArgs e)
        {
            if (v.validarDireccion(textDir.Text))
            {

            }
            else
            {
                if (MessageBox.Show("Desea repetir el ingreso?", "Dirección inválida", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textDir.Text = "";
                }
                else
                {

                    new MenuPrincipal().Show();
                    this.Visible = false;

                }

            }


        }*/

      
    }
}
