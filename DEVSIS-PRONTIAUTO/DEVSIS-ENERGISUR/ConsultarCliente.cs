using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace DEVSIS_ENERGISUR
{
    public partial class ConsultarCliente : Form
    {
        Conexion1 c1 = new Conexion1();
        Validaciones v = new Validaciones();

        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                DialogResult opcion;
                if (textCodigo.Text.Length > 80)


                {
                    opcion = MessageBox.Show("Nombre invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (opcion == DialogResult.OK)
                    {
                        opcion = MessageBox.Show("Desea repetir el ingreso", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (opcion == DialogResult.Yes)
                        {
                            textCodigo.Text = " ";
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
                v.VerificaCedula(textCodigo.Text);
            }
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prontiautoDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
            //this.cLIENTESTableAdapter.Fill(this.prontiautoDataSet.CLIENTES);comentale
           
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                v.Nombres(e);
            }else
            {
                v.Numeros(e);
            }
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            string acumulaError = "";

            if (comboBox1.SelectedIndex.Equals(1))
            {
                if (v.VerificaCedula(textCodigo.Text))
                {
                    c1.mostrarC(Convert.ToInt32(textCodigo.Text), dataGridView1);
                }
                else if (textCodigo.Text == String.Empty)
                {
                    acumulaError = "Entrada de número de cédula vacía";
                    MessageBox.Show(acumulaError);
                    acumulaError = "";
                }
                else if (textCodigo.TextLength < 10)
                {
                    acumulaError = "Número de cédula no válido";
                    MessageBox.Show(acumulaError);
                    acumulaError = "";
                    textCodigo.Text = "";

                }
                else
                {
                    acumulaError = "Número de cédula no válido";
                    MessageBox.Show(acumulaError);
                }


            }
            else
                c1.mostrarN(textCodigo.Text, dataGridView1);
            
            
        }

        
    }
}
