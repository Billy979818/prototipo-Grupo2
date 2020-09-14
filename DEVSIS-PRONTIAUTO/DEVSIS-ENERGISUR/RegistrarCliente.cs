using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class RegistrarCliente : Form
    {
        Conexion1 c1 = new Conexion1();
        Validaciones v = new Validaciones();
       
        public RegistrarCliente()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textTelefono.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            botonIngresar.Enabled = true;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textTelefono.Text = " ";
            textBox3.Text = " ";
            textBox1.Text = "";
            dateTimePicker1.Enabled = false;
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Enabled = false;
            botonIngresar.Enabled = false;

        }

        private void labelIngresarProducto_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            if (c1.personaRegistrada(Convert.ToInt32(textBox1.Text)) == 0)
            {

                c1.InsertarCliente(textTelefono.Text, Convert.ToInt32(textBox1.Text), dateTimePicker1.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show("Cliente registrado exitosamente");
            }
            MessageBox.Show("Cliente ya se encuentra registrado");
 
        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {
            DialogResult opcion;
            if (textTelefono.Text.Length < 4) {
                textBox1.Enabled = false;
            }

            else if (textTelefono.Text.Length > 80)


            {
                opcion = MessageBox.Show("Nombres completos invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (opcion == DialogResult.OK)
                {
                    opcion = MessageBox.Show("Desea repetir el ingreso", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcion == DialogResult.Yes)
                    {
                        textTelefono.Text = " ";
                    }
                    else
                    {
                        new MenuPrincipal().Show();
                        this.Visible = false;
                    }

                }
            }

            else
                textBox1.Enabled = true;

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (v.VerificaCedula(textBox1.Text))
            {
                
            }
            else if (textBox1.Text == String.Empty)
            {
                if (MessageBox.Show("Desea repetir el ingreso?", "Entrada de número de cédula de ciudadanía vacía", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textBox1.Text = "";
                    textBox1.Enabled = true;
                }
                else
                {

                    new MenuPrincipal().Show();
                    this.Visible = false;

                }

            }
            else if (textBox1.TextLength < 10)
            {
                if (MessageBox.Show("Desea repetir el ingreso", "Número de cédula de ciudadanía inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textBox1.Text = "";
                }
                else
                {

                    new MenuPrincipal().Show();
                    this.Visible = false;

                }
            }
            else
            {
                if (MessageBox.Show("Desea repetir el ingreso?", "Número de cédula de ciudadanía inválido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textBox1.Text = "";
                }
                else
                {

                    new MenuPrincipal().Show();
                    this.Visible = false;

                }

            }
            dateTimePicker1.Enabled = true;


        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Nombres(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            textBox3.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DialogResult opcion;
            if (textBox4.Text.Length < 10)
            {
                textBox5.Enabled = false;
            }
            else if (textBox5.Text.Length > 50)
            {
                opcion = MessageBox.Show("Dirección incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (opcion == DialogResult.OK)
                {
                    opcion = MessageBox.Show("Desea repetir el ingreso", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcion == DialogResult.Yes)
                    {
                        textBox4.Text = " ";
                    }
                    else
                    {
                        new MenuPrincipal().Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    new MenuPrincipal().Show();
                    this.Visible = false;
                }
            }

            else 
            {
                textBox5.Enabled = true;
            }
                
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            if (v.validarEmail(textBox5.Text))
            {

             }
            else
            {
                MessageBox.Show("Dirrección de correo electrónico no es válida, por favor ingrese un correo electrónico válido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

               
        }

    

    private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            DialogResult opcion;
            if (textBox3.Text.Length < 7)
            {
                textBox4.Enabled = false;
            }

            else if (textBox3.Text.Length > 10)
            {
                opcion = MessageBox.Show("Número de teléfono incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (opcion == DialogResult.OK)
                {
                    opcion = MessageBox.Show("Desea repetir el ingreso", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcion == DialogResult.Yes)
                    {
                        textBox3.Text = " ";
                    }
                    else
                    {
                        new MenuPrincipal().Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    new MenuPrincipal().Show();
                    this.Visible = false;
                }

            }
            else
            {
                textBox4.Enabled = true;
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

