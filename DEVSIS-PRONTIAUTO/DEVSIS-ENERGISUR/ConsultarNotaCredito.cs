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
    public partial class ConsultarNotaCredito : Form
    {
        public ConsultarNotaCredito()
        {
            InitializeComponent();
            busquedaNota.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
            //string cadena = "Data Source=.;Initial Catalog=Prontiauto;Integrated Security=True";
            SqlConnection cn;
            cn = new SqlConnection(cadena);

            string busqueda = "";

            switch (eleccionNota.Text)
            {
                case "Factura":
                    busqueda = busquedaNota.Text;
                    int num = Convert.ToInt32(busqueda);
                    cn.Open();

                    SqlDataAdapter da = new SqlDataAdapter("select * from NOTADECREDITO N JOIN FACTURA F ON F.NUM_FAC = N.NUM_FAC WHERE F.NUM_FAC = " + num, cn);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dataGridView1.Rows.Count == 1)
                    {
                        DialogResult resultado = MessageBox.Show("El código ingresado no se encuentra en el sistema. ¿Desea ingresar nuevamente el código?", "Alerta", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {
                            busquedaNota.Text = "";
                        }
                        else
                        {
                            new MenuPrincipal().Show();
                            this.Visible = false;
                        }
                    }

                    cn.Close();
                    break;

                case "Nota de crédito":
                    
                    busqueda = busquedaNota.Text;
                    int num2 = Convert.ToInt32(busqueda);
                    cn.Open();

                    SqlDataAdapter da2 = new SqlDataAdapter("select * from NOTADECREDITO N JOIN FACTURA F ON F.NUM_FAC = N.NUM_FAC WHERE N.NUM_NCREDITO = " + num2, cn);
                    DataTable dt2 = new DataTable();

                    da2.Fill(dt2);

                    dataGridView1.DataSource = dt2;

                    cn.Close();

                    break;

            }

            /*cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from NOTADECREDITO N JOIN FACTURA F ON F.NUM_FAC = N.NUM_FAC", cn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void eleccionNota_Click(object sender, EventArgs e)
        {

        }

        private void eleccionNota_MouseCaptureChanged(object sender, EventArgs e)
        {
            busquedaNota.Enabled = true;
        }
    }
}
