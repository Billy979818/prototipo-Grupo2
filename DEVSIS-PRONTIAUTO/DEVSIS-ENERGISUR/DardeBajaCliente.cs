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
    public partial class DardeBajaCliente : Form
    {

        Validaciones v = new Validaciones();
        
        
        public DardeBajaCliente()
        {
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }
        private void labelCodigo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DardeBajaCliente_Load(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection cn = new SqlConnection(cadena);
                cn.Open();

                string nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string cedula = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string fechaN = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string celular = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string direccion = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string email = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                if (String.Equals(nombre,"") != true)
                {
                    string insertar = "insert into CLIENTES_DADOS_BAJA values " +
                    " ('" + nombre + "'," + cedula + ",'" + fechaN + "','" + celular + "','" + direccion + "','" + email + "')";

                    SqlCommand com = new SqlCommand(insertar, cn);

                    string eliminar = "delete from CLIENTES where CEDULA = " + cedula;
                    com.ExecuteNonQuery();

                    com = new SqlCommand(eliminar, cn);
                    com.ExecuteNonQuery();

                    cedulaBusqueda.Text = "";

                    actualizarTabla();

                    cn.Close();
                }
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la cédula");
            }
        }

        // Consulta mientras se tipea
        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            actualizarTabla();
        }

        private void cedulaDarBaja(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void textCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            actualizarTabla();
            
        }

        public void actualizarTabla()
        {
            try
            {
                string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection cn;
                cn = new SqlConnection(cadena);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from CLIENTES WHERE CEDULA LIKE '" + cedulaBusqueda.Text + "%'", cn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dataGridView1.Rows.Count == 1 && cedulaBusqueda.Text.Length == 10)
                {
                    if (v.VerificaCedula(cedulaBusqueda.Text) == false)
                    {
                        DialogResult resultado = MessageBox.Show("Cédula no válida. ¿Desea repetir el ingreso?", "Alerta", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {
                            cedulaBusqueda.Text = "";
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
                            cedulaBusqueda.Text = "";
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
    }
}
