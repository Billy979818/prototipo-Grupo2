using DEVSIS_ENERGISUR.control;
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
    public partial class DardeAltaCliente : Form
    {
        Validaciones v = new Validaciones();

        public DardeAltaCliente()
        {
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void labelIngresarProducto_Click(object sender, EventArgs e)
        {

        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        public void actualizarTabla()
        {
            try
            {
                string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
                SqlConnection cn;
                cn = new SqlConnection(cadena);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from CLIENTES_DADOS_BAJA WHERE CEDULA_B LIKE '" + textCodigo.Text + "%'", cn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dataGridView1.Rows.Count == 1 && textCodigo.Text.Length == 10)
                {
                    if (v.VerificaCedula(textCodigo.Text) == false)
                    {
                        DialogResult resultado = MessageBox.Show("Cédula no válida. ¿Desea repetir el ingreso?", "Alerta", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {
                            textCodigo.Text = "";
                        }
                        else
                        {
                            new MenuPrincipal().Show();
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Cliente no registrado. ¿Desea repetir el ingreso?", "Alerta", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {
                            textCodigo.Text = "";
                        }
                        else
                        {
                            new MenuPrincipal().Show();
                            this.Visible = false;
                        }
                    }
                }


                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el cliente");
            }
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
                SqlConnection cn = new SqlConnection(cadena);
                cn.Open();

                string nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string cedula = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string fechaN = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string celular = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string direccion = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string email = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                if (String.Equals(nombre, "") != true)
                {
                    string insertar = "insert into CLIENTES values " +
                    " ('" + nombre + "'," + cedula + ",'" + fechaN + "','" + celular + "','" + direccion + "','" + email + "')";

                    SqlCommand com = new SqlCommand(insertar, cn);

                    string eliminar = "delete from CLIENTES_DADOS_BAJA where CEDULA_B = " + cedula;
                    com.ExecuteNonQuery();

                    com = new SqlCommand(eliminar, cn);
                    com.ExecuteNonQuery();

                    textCodigo.Text = "";

                    actualizarTabla();

                    cn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la cédula");
            }
        }

        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            actualizarTabla();
        }

        private void textCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            actualizarTabla();
        }
    }
}
