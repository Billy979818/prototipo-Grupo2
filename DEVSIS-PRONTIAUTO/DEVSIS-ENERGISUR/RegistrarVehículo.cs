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
    public partial class RegistrarVehículo : Form
    {
        string cadena = "Data Source=DESKTOP-1E84QEA;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
        //string cadena = "Data Source=CHRISTOPHER;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=leonardo2c";
        //string cadena = "Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456";
        SqlCommand cmd;
        SqlDataReader dr;
        public SqlConnection cn = new SqlConnection();
        Validaciones v = new Validaciones();
        public RegistrarVehículo()
        {
            InitializeComponent();
            cn.ConnectionString = cadena;
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Close();
        }
        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textMarca.Text = "";
            textPlaca.Text = "";
            textModel.Text = "";
            textKm.Text = "";
            textPC.Text = "";
            textPV.Text = "";
        }

        private void RegistrarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string m = textMarca.Text;
                string p = textPlaca.Text;
                string t = this.comboBox1.Text;
                string mod = textModel.Text;
                string km = textKm.Text;
                string pc = textPC.Text;
                string pv = textPV.Text;
                ValidartextPlaca(p);
                ValidartextMarca(m);
                ValidartextModelo(mod);
                ValidartextKm(km);
                ValidartextPC(pc);
                ValidartextPV(pv);

                string cadena = "insert into VEHICULOS(MARCA,PLACA,TIPO,MODELO,KILOMETRAJE,PRECIO_COMPRA,PRECIO_VENTA)values ('" + m + "','" + p + "','" + t + "','" + mod + "'," + km + "," + pc + "," + pv + ")";
                SqlCommand comando = new SqlCommand(cadena, cn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Vehículo registrado correctamente");
                bt_limpiar.Enabled = true;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vehículo no registrado");
            }


        }

//validaciones

        private void ValidartextPlaca(string placa)
        {
            if (v.validarPlaca(placa))
            {

            }
            else if (placa == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de Placa vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textPlaca.Text = "";

                }
                else
                {

                    bt_limpiar.Enabled = true;

                }

            }

            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Placa inválida", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textPlaca.Text = "";
                }
                else
                {
                    bt_limpiar.Enabled = true;

                }

            }


        }
        /*private void textPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((int)e.KeyChar == (int)Keys.Tab)
            {
                ValidartextPlaca(textPlaca.Text);
            }
        }*/
        private void ValidartextMarca(string marca)
        {
            if (v.validarNombre(marca))
            {

            }
            else if (marca == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de Marca vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textMarca.Text = "";

                }
                else
                {
                    bt_limpiar.Enabled = true;


                }

            }
            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Marca inválida", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textMarca.Text = "";
                }
                else
                {
                    bt_limpiar.Enabled = true;


                }

            }


        }


        private void ValidartextModelo(string modelo)
        {
            if (v.validarNombre(modelo))
            {

            }
            else if (modelo == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de Modelo vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textModel.Text = "";

                }
                else
                {

                    bt_limpiar.Enabled = true;


                }

            }
            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Modelo inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textModel.Text = "";
                }
                else
                {
                    bt_limpiar.Enabled = true;


                }

            }


        }

        private void ValidartextPC(string pc)
        {
            if (v.validarNumeros(pc))
            {

            }
            else if (pc == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de precio de compra vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textPC.Text = "";

                }
                else
                {

                    bt_limpiar.Enabled = true;
                }

            }

            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Precio de compra inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textPC.Text = "";
                }
                else
                {
                    bt_limpiar.Enabled = true; ;

                }

            }


        }



        private void ValidartextPV(string pv)
        {
            if (v.validarNumeros(pv))
            {

            }
            else if (pv == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de precio de venta vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textPV.Text = "";

                }
                else
                {

                    bt_limpiar.Enabled = true;

                }

            }

            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Precio de venta inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textPV.Text = "";
                }
                else
                {
                    bt_limpiar.Enabled = true;

                }

            }


        }



        private void ValidartextKm(string km)
        {
            if (v.validarNumeros(km))
            {

            }
            else if (km == String.Empty)
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Entrada de kilometraje vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textKm.Text = "";

                }
                else
                {

                    bt_limpiar.Enabled = true;

                }

            }

            else
            {
                if (MessageBox.Show("¿Desea repetir el ingreso?", "Kilometraje inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textKm.Text = "";
                }
                else
                {
                    bt_limpiar.Enabled = true;
                }

            }


        }

        private void RegistrarVehículo_Load(object sender, EventArgs e)
        {

        }
    }
}
