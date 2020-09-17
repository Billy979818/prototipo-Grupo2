using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class GenerarFactura : Form
    {

        string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
        public SqlConnection cn = new SqlConnection();
        Validaciones v = new Validaciones();
        private DataSet ds;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        public GenerarFactura()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }

        public void cargarVehiculos()
        {
            SqlCommand cmd = new SqlCommand("SELECT placa FROM VEHICULOS", cn);
            cn.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                comboBox1.Items.Add(registro["PLACA"].ToString());
            }
            cn.Close();
        }

        public void limpiarCampos()
        {
            txt_num.Text = "";
            txt_vendedor.Text = "";
            txt_cedula.Text = "";
            txt_correo.Text = "";
            txt_descuento.Text = "";
            txt_direccion.Text = "";
            txt_total.Text = "";
            txt_vendedor.Text = "";
            txt_nombre.Text = "";
            txt_iva.Text = "";
            txt_subtotal.Text = "";
            txt_telefono.Text = "";
            tb_vehiculos.DataSource = "";
            comboBox1.Text = "";

        }
        public void mostrarV(string placa, DataGridView datos)
        {
            try
            {
                da = new SqlDataAdapter("select MARCA,TIPO, MODELO, PRECIO_VENTA from VEHICULOS WHERE PLACA =" + "'" + placa + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
                datos.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void cargarNumFactura()
        {
            int num_factura;
            cn.Open();
            string consult = "SELECT NUM_FAC FROM FACTURA WHERE NUM_FAC = (SELECT MAX(NUM_FAC) from FACTURA)";
            SqlCommand comando = new SqlCommand(consult, cn);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txt_num.Text = registro["NUM_FAC"].ToString();
            }

            num_factura = int.Parse(registro["NUM_FAC"].ToString());
            int numero = num_factura + 1;
            txt_num.Text = numero.ToString();
            cn.Close();
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void labelGenerarFactura_Click(object sender, EventArgs e)
        {

        }

        private void labelNumeroCuenta_Click(object sender, EventArgs e)
        {

        }

        private void GenerarFactura_Load(object sender, EventArgs e)
        {
            try
            {
                cargarVehiculos();
                cargarNumFactura();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCancelar(object sender, EventArgs e)
        {
            // new MenuPrincipal().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string placa = (string)comboBox1.SelectedItem.ToString();
            float precio_venta;
            try
            {
                mostrarV(placa, tb_vehiculos);
                cn.Open();
                string consult = "select PRECIO_VENTA from VEHICULOS WHERE PLACA =" + "'" + placa + "'";
                SqlCommand comando = new SqlCommand(consult, cn);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txt_subtotal.Text = registro["PRECIO_VENTA"].ToString();

                }

                precio_venta = float.Parse(registro["PRECIO_VENTA"].ToString());
                //MessageBox.Show("El precio de venta" + precio_venta);

                float iva = (14 * precio_venta) / 100;
                txt_iva.Text = iva.ToString();

                float total = precio_venta + iva;

                txt_total.Text = total.ToString();


                cn.Close();



                //if(txt_subtotal.Text != string.Empty)
                //{
                //    int precio_venta = int.Parse(txt_subtotal.Text.ToString());
                //    float iva = (12 * precio_venta) / 100;
                //    txt_iva.Text = iva.ToString();
                //}
                //else
                //{
                //    MessageBox.Show("No existe datos en el subtotal");
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();

            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            txt_cedula.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num_fac = txt_num.Text;
            string nombre_ven = txt_vendedor.Text;
            string cedula = txt_cedula.Text;
            string nombre = txt_nombre.Text;
            string mail = txt_correo.Text;
            string direccion = txt_direccion.Text;
            string telefono = txt_telefono.Text;
            string precio_ve = txt_subtotal.Text;
            string subtotal = txt_subtotal.Text;
            string descuento = txt_descuento.Text;
            string iva = txt_iva.Text;
            string total = txt_total.Text;
            string cadena = "";

            if (txt_descuento.Text != string.Empty)
            {
                cadena = "insert into FACTURA (NUM_FAC,FECHA_EMISION,NOM_VENDEDOR,CEDULA_CLIE,NOMBRE_CLI,CORREO_CLI,DIRECCION_CLI,TELEFONO_CLI,PRECIO_VEHI,SUBTOTTAL,DESCUENTO,IVA,TOTAL) values (" + num_fac + ", '" + txt_fecha.Value.ToString("yyyy-MM-dd") + "'" + ", '" + nombre_ven + "'" + ", '" + cedula + "'" + ", '" + nombre + "'" + ", '" + mail + "'" + ", '" + direccion + "'" + ", '" + telefono + "'" + "," + precio_ve + "," + subtotal + "," + descuento + "," + iva + "," + total + ")";
            }

            else
            {
                cadena = "insert into FACTURA (NUM_FAC,FECHA_EMISION,NOM_VENDEDOR,CEDULA_CLIE,NOMBRE_CLI,CORREO_CLI,DIRECCION_CLI,TELEFONO_CLI,PRECIO_VEHI,SUBTOTTAL,IVA,TOTAL) values (" + num_fac + ", '" + txt_fecha.Value.ToString("yyyy-MM-dd") + "'" + ", '" + nombre_ven + "'" + ", '" + cedula + "'" + ", '" + nombre + "'" + ", '" + mail + "'" + ", '" + direccion + "'" + ", '" + telefono + "'" + "," + precio_ve + "," + subtotal + "," + iva + "," + total + ")";
            }

            try
            {
                cn.Open();

                SqlCommand comando = new SqlCommand(cadena, cn);
                comando.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("factur registrada con éxito");



                //limpiarCampos();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(cadena);

            }

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

            //if (txt_cedula.Text == string.Empty)
            //{
            //    MessageBox.Show("Ingrese la cedula del cliente");
            //    v.validarNumeros(txt_cedula.Text);
            //}
            //else if (txt_cedula.Text.Length == 10)
            //{
            //    v.validarNumeros(txt_cedula.Text);
            //    try
            //    {
            //        cn.Open();
            //        Console.WriteLine("Conexion Exitosa");
            //        string ced = txt_cedula.Text;
            //        string consult = "select * from CLIENTES where CEDULA=" + ced;
            //        SqlCommand comando = new SqlCommand(consult, cn);
            //        SqlDataReader registro = comando.ExecuteReader();
            //        if (registro.Read())
            //        {
            //            txt_cedula.Text = registro["CEDULA"].ToString();
            //            txt_nombre.Text = registro["NOMBRES"].ToString();
            //            txt_telefono.Text = registro["CELULAR"].ToString();
            //            txt_direccion.Text = registro["DIRECCION"].ToString();
            //            txt_correo.Text = registro["EMAIL"].ToString();
            //            cn.Close();
            //            txt_cedula.Enabled = false;
            //        }
            //        else
            //            MessageBox.Show("Cliente no registrado");
            //        cn.Close();

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}

        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //limpiarCampos();
        }

        private void txt_cedula_TextChanged(object sender, EventArgs e)
        {
            if (txt_cedula.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la cedula del cliente");
                v.validarNumeros(txt_cedula.Text);
            }
            else if (txt_cedula.Text.Length == 10)
            {
                v.validarNumeros(txt_cedula.Text);
                try
                {
                    cn.Open();
                    Console.WriteLine("Conexion Exitosa");
                    string ced = txt_cedula.Text;
                    string consult = "select * from CLIENTES where CEDULA=" + ced;
                    SqlCommand comando = new SqlCommand(consult, cn);
                    SqlDataReader registro = comando.ExecuteReader();
                    if (registro.Read())
                    {
                        txt_cedula.Text = registro["CEDULA"].ToString();
                        txt_nombre.Text = registro["NOMBRES"].ToString();
                        txt_telefono.Text = registro["CELULAR"].ToString();
                        txt_direccion.Text = registro["DIRECCION"].ToString();
                        txt_correo.Text = registro["EMAIL"].ToString();
                        cn.Close();
                        txt_cedula.Enabled = false;
                    }
                    else
                        MessageBox.Show("Cliente no registrado");
                    cn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
            txt_cedula.Enabled = true;
        }
    }
}
