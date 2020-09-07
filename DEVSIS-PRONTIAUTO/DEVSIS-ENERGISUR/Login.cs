using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class Login : Form
    {

        String contrasena = "Grupo-2";
        String usuario = "1725996365";

        Validaciones v = new Validaciones();
        public Login()
        {
            InitializeComponent();
        }

        public bool VerificaCedula(string ced)
        {
            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincia = 24;
            const int tercerDigito = 6;

            if (int.TryParse(ced, out isNumeric) && ced.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincia) && digitoTres < tercerDigito)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(ced[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) * Convert.ToInt32(ced[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;
                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }
                return false;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textCedula.Text != usuario)
            {
                MessageBox.Show("Usuario no registrado");
            }
            else
            {
                if(textContrasena.Text != contrasena)
                {
                    MessageBox.Show("Contraseña incorrecta");
                    textContrasena.Text = "";
                }
                else
                {
                    if(comboBox1.Text != "Administración")
                    {
                        MessageBox.Show("Usuario no registrado");
                    }
                    else
                    {
                        MenuPrincipal menu = new MenuPrincipal();
                        menu.Show();
                        this.Visible = false;
                    }
                }
            }
                
        }

        private void textCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textContrasena.Focus();
            }
        }

        

        private void textCedula_Leave(object sender, EventArgs e)
        {
            if (VerificaCedula(textCedula.Text))
            {
                
            }
            else if (textCedula.Text == String.Empty)
            {
                MessageBox.Show("Entrada de número cédula vacía");
            }
            else if (textCedula.TextLength < 10)
            {
                MessageBox.Show("Número de cédula incompleto");
            }
            else
            {
                MessageBox.Show("Número de cédula no válido");

            }
            
            
        }


        
        private void textContrasena_Leave(object sender, EventArgs e)
        {
            if (textContrasena.Text == String.Empty || textContrasena.Text != contrasena)
            {
                MessageBox.Show("Entrada de contraseña vacía");
            }
        }

        private void textContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button2.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
