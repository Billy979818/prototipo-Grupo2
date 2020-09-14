using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class EmitirReporteClientes : Form
    {

        string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
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
        public EmitirReporteClientes()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;


        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Restaurar Base de datos";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string database = cn.Database.ToString();

            try
            {
                string cmd = "USE MASTER RESTORE DATABASE ["+ database +"] FROM DISK = '" + textBox1.Text + "' WITH REPLACE; ";
                Abrir();
                SqlCommand command = new SqlCommand(cmd, cn);
                command.ExecuteNonQuery();
                Cerrar();
                tabla2.DataSource = MostrarDatos();
                //MessageBox.Show("Base de datos restaurada correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }

            
        }
    }
}
