using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class IngresarProductoVehiculo : Form
    {
        Validaciones v = new Validaciones();

        public IngresarProductoVehiculo()
        {
            InitializeComponent();
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        public static bool validarCodigo(String codigo)
        {
            String rx = "^[0-9]{3}[A-Z]{7}$";
            if (Regex.IsMatch(codigo, rx))
            {
                if (Regex.Replace(codigo, rx, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool validarNombre(String cadena)
        {
            String rx = "^[a-zA-Z_]+( [a-zA-Z_]+)*$";
            if (Regex.IsMatch(cadena, rx))
            {
                if (Regex.Replace(cadena, rx, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool validarNumeros(String cadena)
        {
            String rx = "^[0-9]+$";
            if (Regex.IsMatch(cadena, rx))
            {
                if (Regex.Replace(cadena, rx, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool validarNumerosDecimales(String cadena)
        {
            String rx = "^[0-9]+([.|,][0-9]+)?$";
            if (Regex.IsMatch(cadena, rx))
            {
                if (Regex.Replace(cadena, rx, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void textCodigo_Leave(object sender, EventArgs e)
        {
            if (validarCodigo(textCodigo.Text))
            {

            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Nombres(e);
        }

        private void textNombreProducto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textNombreProducto_Leave(object sender, EventArgs e)
        {
            if (validarNombre(textNombreProducto.Text))
            {
                if(textNombreProducto.TextLength > 50)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textBoxGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        //private void textBoxGarantia_Leave(object sender, EventArgs e)
        //{
        //    if (validarNumeros(textBoxGarantia.Text))
        //    {
        //        if (textBoxGarantia.TextLength > 10)
        //        {
        //            MessageBox.Show("Formato incorrecto");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Formato incorrecto");
        //    }
        //}

        private void textMarca_Leave(object sender, EventArgs e)
        {
            if (validarNombre(textMarca.Text))
            {
                if (textMarca.TextLength > 20)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textVoltaje_Leave(object sender, EventArgs e)
        {
            if (validarNumeros(textVoltaje.Text))
            {
                if (textVoltaje.TextLength > 3)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        //private void textAmperaje_Leave(object sender, EventArgs e)
        //{
        //    if (validarNumeros(textAmperaje.Text))
        //    {
        //        if (textAmperaje.TextLength > 3)
        //        {
        //            MessageBox.Show("Formato incorrecto");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Formato incorrecto");
        //    }
        //}

        //private void textCantidad_TextChanged(object sender, EventArgs e)
        //{
        //    if (validarNumeros(textCantidad.Text))
        //    {
        //        if (textCantidad.TextLength > 4)
        //        {
        //            MessageBox.Show("Formato incorrecto");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Formato incorrecto");
        //    }
        //}

        private void textPrecio_Leave(object sender, EventArgs e)
        {
            if (validarNumerosDecimales(textPrecio.Text))
            {
                
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textVoltaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        private void textAmperaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        private void textAmperaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }
    }
}
