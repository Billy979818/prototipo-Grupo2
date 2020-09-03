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
    public partial class EmitirFacturaElectrónica : Form
    {
        public EmitirFacturaElectrónica()
        {
            InitializeComponent();
        }

        private void labelDierccion_Click(object sender, EventArgs e)
        {

        }

        private void EmitirFacturaElectrónica_Load(object sender, EventArgs e)
        {

        }

        private void BotonCancelar(object sender, EventArgs e)
        {
          //  new MenuPrincipal().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Close();

        }
    }
}
