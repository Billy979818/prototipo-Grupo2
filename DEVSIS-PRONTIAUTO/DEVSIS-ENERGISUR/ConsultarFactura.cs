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
    public partial class ConsultarFactura : Form
    {
        public SqlConnection cn = new SqlConnection();
        string cadena = "Data Source=.;Initial Catalog=Prontiauto;Integrated Security=True";
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        Validaciones v = new Validaciones();
        public ConsultarFactura()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
            //buttonAnular.Enabled = false;
        }

        private void labelGenerarFactura_Click(object sender, EventArgs e)
        {

        }

        private void BotonCancelar(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void ConsultarFactura_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {

                mostrarPorCodigo(Convert.ToInt32(textConsultar.Text), dataGridView1);
            }else if (comboBox1.SelectedIndex.Equals(1))
            {
                if (v.VerificaCedula(textConsultar.Text)) { 
                mostrarPorCedula(textConsultar.Text, dataGridView1);
                }else
                {
                    MessageBox.Show("Numero de cédula incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.SelectedIndex.Equals(2))
            {
                 if (textConsultar.Text.Length > 80)
                {
                    MessageBox.Show("Desea repetir el ingreso","Nombre icorrecto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }else
                    mostrarPorNombre(textConsultar.Text, dataGridView1);
            }else if (comboBox1.SelectedIndex.Equals(3))
            {
                mostrarPorFecha(textConsultar.Text, dataGridView1);
            }
        }
        public void mostrarPorCedula(string cedula, DataGridView datos)
        {
            

            try
            {
              
                da = new SqlDataAdapter("SELECT * FROM FACTURA WHERE CEDULA_CLIE = '" + cedula + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
                datos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha encontrado la factura con el número de cédula ingresado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void mostrarPorCodigo(int codigo, DataGridView datos)
        {
          
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT * FROM dbo.FACTURA WHERE NUM_FAC = " +codigo , cn);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha encontrado el código de la factura ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void mostrarPorNombre(string nombre, DataGridView datos)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM dbo.FACTURA WHERE NOMBRE_CLI = '" + nombre + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
               // dataGridView1.DataSource = dt;
                datos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha encontrado la factura con el nombre ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void mostrarPorFecha(string fechaEmision, DataGridView datos)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM dbo.FACTURA WHERE FECHA_EMISION = " + "'" + fechaEmision + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
                datos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se han encontrado facturas en la fecha ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                
            }
            if (comboBox1.SelectedIndex.Equals(1))
            {
                v.VerificaCedula(textConsultar.Text);

            }
            else if (comboBox1.SelectedIndex.Equals(2))
            {
                DialogResult opcion;
                if (textConsultar.Text.Length > 80)

                {
                    opcion = MessageBox.Show("Nombre invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (opcion == DialogResult.OK)
                    {
                        opcion = MessageBox.Show("¿Desea repetir el ingreso?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (opcion == DialogResult.Yes)
                        {
                            textConsultar.Text = " ";
                        }
                        else
                        {
                            new MenuPrincipal().Show();
                            this.Visible = false;
                        }

                    }


                }
            }
            else
            {

            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                v.Numeros(e);
            }
            else if (comboBox1.SelectedIndex.Equals(1))
            {
                v.Numeros(e);
            }
            else if (comboBox1.SelectedIndex.Equals(2))
            {
                v.Nombres(e);
            }
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAnular.Enabled = true;
        }

        private void buttonAnular_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea anular la factura?", "Alerta", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                if (dataGridView1.Rows.Count > 1)
                {
                    GenerarNotaCredito gn = new GenerarNotaCredito();
                    string nFactura = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    gn.anularDesdeConsulta(nFactura);
                    gn.Show();
                    this.Close();
                }
            }
            else
            {
                new ConsultarFactura().Show();
                this.Visible = false;
            }
            
        }
    }
}
