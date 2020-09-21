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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection;
using Org.BouncyCastle.Utilities;
using System.Runtime.InteropServices.WindowsRuntime;
using iTextSharp.text.xml;

namespace DEVSIS_ENERGISUR
{

    public partial class GenerarNotaCredito : Form
    {
        Validaciones v = new Validaciones();

        public GenerarNotaCredito()
        {
            InitializeComponent();
                        
            textBoxNombre.Enabled = false;
            descripcion.Enabled = false;
            fechaEmision.Enabled = false;
            buttongenerar.Enabled = false;
            notaDeCredito.Enabled = false;

            actualizrNota();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private void textFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        public void actualizarTabla()
        {

            textBoxNombre.Enabled = true;
            try
            {
                string cadena = "Data Source=.;Initial Catalog=Prontiauto;Integrated Security=True";
                //string cadena = "Data Source=CHRISTOPHER;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=leonardo2c";
                SqlConnection cn;
                cn = new SqlConnection(cadena);
                int numero = Convert.ToInt32(textFactura.Text);

                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from FACTURA WHERE NUM_FAC = " + numero, cn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                datosFacturas.DataSource = dt;

                cn.Close();

            }
            catch (Exception ex)
            {
                DialogResult resultado = MessageBox.Show("¿Desea buscar otra factura?", "Alerta", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    textFactura.Text = "0";
                    textBoxNombre.Enabled = false;
                    descripcion.Enabled = false;
                }
                else
                {
                    new MenuPrincipal().Show();
                    this.Visible = false;
                }
            }
        }


        private void textFactura_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textFactura_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarTabla();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxNombre_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Nombres(e);
            descripcion.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textFactura.Text = "";
            textBoxNombre.Text = "";
            descripcion.Text = "";
            datosFacturas.DataSource = null;
            textBoxNombre.Enabled = false;
            descripcion.Enabled = false;
        }

        private void descripcion_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void buttongenerar_Click(object sender, EventArgs e)
        {
            string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
            SqlConnection cn;
            cn = new SqlConnection(cadena);

            string nFactura = datosFacturas.CurrentRow.Cells[0].Value.ToString();
            string fecha = datosFacturas.CurrentRow.Cells[1].Value.ToString();
            string nVendedor = datosFacturas.CurrentRow.Cells[2].Value.ToString();
            string cedula = datosFacturas.CurrentRow.Cells[3].Value.ToString();
            string nCliente = datosFacturas.CurrentRow.Cells[4].Value.ToString();
            string correo = datosFacturas.CurrentRow.Cells[5].Value.ToString();
            string direccion = datosFacturas.CurrentRow.Cells[6].Value.ToString();
            string telefono = datosFacturas.CurrentRow.Cells[7].Value.ToString();
            string precio = datosFacturas.CurrentRow.Cells[8].Value.ToString();
            string subtotal = datosFacturas.CurrentRow.Cells[9].Value.ToString();
            string descuento = datosFacturas.CurrentRow.Cells[10].Value.ToString();
            string iva = datosFacturas.CurrentRow.Cells[11].Value.ToString();
            string total = datosFacturas.CurrentRow.Cells[12].Value.ToString();

            string nNotaCredito = notaDeCredito.Text;
            string encargado = textBoxNombre.Text;
            string desc = descripcion.Text;
            string fechaNCredito = fechaEmision.Text;
            int numeroNota = 0;

            cn.Open();

            string sql = "SELECT TOP 1 NUM_NCREDITO FROM NOTADECREDITO ORDER BY NUM_NCREDITO DESC";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                numeroNota = Convert.ToInt32(reader["NUM_NCREDITO"].ToString()) + 1;
            }

            notaDeCredito.Text = Convert.ToString(numeroNota);
            cn.Close();

            int numeroFactura = Convert.ToInt32(nFactura);

            try
            {
            string consulta = "insert INTO NOTADECREDITO VALUES (" + numeroNota +",'" + fechaEmision.Value.ToString("yyyy-MM-dd") + "','" + encargado + "'," + numeroFactura  + ",'" + desc + "')";

            cn.Open();
            SqlCommand comando = new SqlCommand(consulta, cn);
            comando.ExecuteNonQuery();
            cn.Close();  

            string tituloNota = "\nDATOS DE LA NOTA DE CRÉDITO\n";
            string tituloFac = "\nDATOS DE LA FACTURA\n";

            string titulo = "\t\tProntiAuto \t\t\n Nota de crédito \n" + fechaNCredito + "\n\n"; 

            Document doc = new Document();
            string nombrePDF = "C:\\Users\\flaco\\Documents\\SEXTO SEMESTRE\\Fundamentos de Software\\Proyecto 2020 -A\\Notas de credito" + 
                    "Nota de crédito " + fechaNCredito + " - " + numeroNota + ".pdf";

            PdfWriter.GetInstance(doc, new FileStream(nombrePDF, FileMode.Create));
            
            
            doc.Open();

            Paragraph title = new Paragraph(string.Format(titulo), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);


            Paragraph subtNota = new Paragraph();
            subtNota.Add(tituloNota);
            subtNota.Alignment = Element.ALIGN_CENTER;
            doc.Add(subtNota);
                        
            PdfPTable tabla = new PdfPTable(1);
            PdfPCell celdaT;
                       
            celdaT = new PdfPCell(new Paragraph("Número de nota de crédito: \n\t" + numeroNota));
            tabla.AddCell(celdaT);

            celdaT = new PdfPCell(new Paragraph("Fecha de emisión: \n\t" + fechaNCredito));
            tabla.AddCell(celdaT);

            celdaT = new PdfPCell(new Paragraph("Responsable: \n\t" + encargado));
            tabla.AddCell(celdaT);

            celdaT = new PdfPCell(new Paragraph("Descripción de la nota de cédito: \n\t" + desc));
            tabla.AddCell(celdaT);

            doc.Add(tabla);

            Paragraph subtFac = new Paragraph();
            subtFac.Add(tituloFac);
            subtFac.Alignment = Element.ALIGN_CENTER;
            doc.Add(subtFac);

            PdfPTable tablaN = new PdfPTable(1);
            PdfPCell celdaN;

            celdaN = new PdfPCell(new Paragraph("Número de la factura: \n\t" + nFactura));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Fecha de facturación: \n\t" + fecha));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Responsable de la factura: \n\t" + nVendedor));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Nombre del cliente: \n\t" + nCliente));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Cédula del cliente: \n\t" + cedula));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Correo electrónico: \n\t" + correo));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Dirección: \n\t" + direccion));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Teléfono: \n\t" + telefono));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Precio: \n\t" + precio));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Subtotal: \n\t" + subtotal));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Descuento: \n\t" + descuento));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("IVA: \n\t" + iva));
            tablaN.AddCell(celdaN);

            celdaN = new PdfPCell(new Paragraph("Total: \n\t" + total));
            tablaN.AddCell(celdaN);

            doc.Add(tablaN);

            doc.Close();

            MessageBox.Show("Nota de crédito generada con éxito.");

            datosFacturas.DataSource = null;

            textFactura.Text = "";
            textBoxNombre.Text = "";
            descripcion.Text = "";
            textBoxNombre.Enabled = false;
            descripcion.Enabled = false;

            actualizrNota();

            }
            catch (Exception ev)
            {
                MessageBox.Show("Error: " + ev);
            }
        }

        public void actualizrNota()
        {
            int numeroNota = 0;

            string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
            SqlConnection cn;
            cn = new SqlConnection(cadena);

            cn.Open();

            string sql = "SELECT TOP 1 NUM_NCREDITO FROM NOTADECREDITO ORDER BY NUM_NCREDITO DESC";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                numeroNota = Convert.ToInt32(reader["NUM_NCREDITO"].ToString()) + 1;
            }

            notaDeCredito.Text = Convert.ToString(numeroNota);
            cn.Close();
                        
        }

        private void datosFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttongenerar.Enabled = true;
        }

        public void anularDesdeConsulta(string idFactura)
        {
            textFactura.Text = idFactura;
        }
    }
}
