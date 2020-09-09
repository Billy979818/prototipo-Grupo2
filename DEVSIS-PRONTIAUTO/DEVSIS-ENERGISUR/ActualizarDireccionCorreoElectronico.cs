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
    public partial class ActualizarDireccionCorreoElectronico : Form
    {
        public ActualizarDireccionCorreoElectronico()
        {
            InitializeComponent();
        }

        private void labelIngresarProducto_Click(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }
    }
}
