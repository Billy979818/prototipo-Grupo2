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
        string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto; Integrated Security=True";
        public SqlConnection cn = new SqlConnection();
     
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

        public void Abrir()
        {
            try
            {
                cn.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la Base de Datos" + ex.Message);
            }

        }

        public void Cerrar()
        {
            cn.Close();
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
                MessageBox.Show("No existe un artículo con el código ingresado");
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
                MessageBox.Show("Se modificó la dirección del cliente correctamente");
                textDir.Text = "";
                new MenuPrincipal().Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            cn.Close();
            botonActualizar.Enabled = false;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

    }
}
