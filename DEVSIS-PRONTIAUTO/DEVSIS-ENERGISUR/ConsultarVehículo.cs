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
    public partial class ConsultarVehículo : Form
    {

        string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
        public SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        Validaciones v = new Validaciones();
        public ConsultarVehículo()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }

        private void ConsultarMarcaVehículo_Load(object sender, EventArgs e)
        {

        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Close();
        }


        public void mostrarMarca(string marca, DataGridView datos)
        {

            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT * FROM VEHICULOS WHERE MARCA = '" + marca + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
                datos.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El vehículo no se encuentra registrado en el sistema");
                MessageBox.Show(ex.Message);

            }
        }

        public void mostrarPlaca(string placa, DataGridView datos)
        {

            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT * FROM VEHICULOS WHERE PLACA ='" + placa + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
                datos.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El vehículo no se encuentra registrado en el sistema");
                MessageBox.Show(ex.Message);
            }
        }


        public void mostrarModelo(string modelo, DataGridView datos)
        {

            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT * FROM VEHICULOS WHERE MODELO = '" + modelo + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
                datos.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El vehículo no se encuentra registrado en el sistema");
                MessageBox.Show(ex.Message);
            }
        }


        private void botonConsultar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                mostrarPlaca(textCodigo.Text, dataGridView1);
            }
            else if (comboBox1.SelectedIndex.Equals(1))
            {
                mostrarMarca(textCodigo.Text, dataGridView1);
            }
            else if (comboBox1.SelectedIndex.Equals(2))
            {
                mostrarModelo(textCodigo.Text, dataGridView1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (v.validarPlaca(textCodigo.Text))
            {

            }
            else if (textCodigo.Text == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de Placa vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textCodigo.Text = "";

                }
                else
                {

                    new ConsultarVehículo().Show();
                    this.Visible = false;

                }

            }
            /*else if (vehiculoRegistrado(textCodigo.Text)==0)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Vehículo no registrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textCodigo.Text = "";
                }
                else
                {
                    new ConsultarVehículo().Show();
                    this.Visible = false;
                }
            }*/
            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Placa inválida", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textCodigo.Text = "";
                }
                else
                {
                    new ConsultarVehículo().Show();
                    this.Visible = false;
                }

            }
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
