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
    public partial class ActualizarCliente : Form
    {
        public ActualizarCliente()
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

        private void ActualizarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
