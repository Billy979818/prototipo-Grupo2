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
    public partial class GenerarFactura : Form
    {
        public GenerarFactura()
        {
            InitializeComponent();
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
