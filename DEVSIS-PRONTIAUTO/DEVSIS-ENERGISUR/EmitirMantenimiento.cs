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
    public partial class EmitirMantenimiento : Form
    {
        public EmitirMantenimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Close();
        }
    }
}
