using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DEVSIS_ENERGISUR
{
    public partial class GenerarCopiaSeguridadClientes : Form
    {


        string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
       // string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456";
        public SqlConnection cn = new SqlConnection();
        private DataSet ds;

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
        public DataTable MostrarDatos()
        {
            Abrir();
            SqlCommand cmd = new SqlCommand("select * from CLIENTES", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla1");
            Cerrar();
            return ds.Tables["tabla1"];
        }


        public GenerarCopiaSeguridadClientes()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GenerarCopiaSeguridadClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla1.DataSource = MostrarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txt_ruta.Text = dlg.SelectedPath;
            }
        }

        private void buttonEmitir_Click(object sender, EventArgs e)
        {
            string database = cn.Database.ToString();

            try
            {
                if(txt_ruta.Text == string.Empty)
                {
                    MessageBox.Show("Por favor seleccione la ruta donde desea guradar la Copia de seguridad");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txt_ruta.Text + "\\" + "Clientes" + "-" + tiempo_respaldo.Value.ToString("yyyy--MM--dd--HH--mm--ss") + ".bak'";
                    Abrir();
                    SqlCommand command = new SqlCommand(cmd, cn);
                    command.ExecuteNonQuery();
                    Cerrar();
                    MessageBox.Show("Copia de seguridad guardada con exito");

                 }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la copia de seguridad" + ex.Message);
            }

           

        }
    }
}
