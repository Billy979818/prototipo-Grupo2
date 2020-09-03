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
    public partial class ConsultarMarcaVehículo : Form
    {
        public ConsultarMarcaVehículo()
        {
            InitializeComponent();
        }

        private void ConsultarMarcaVehículo_Load(object sender, EventArgs e)
        {

        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Close();
        }
    }
}
