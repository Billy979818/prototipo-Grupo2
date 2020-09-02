using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            new CrearUsuario().Show();
        }

        private void eliminarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarUsuario().Show();
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // new IngresarProducto().Show();
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new ActualizarProducto().Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new EliminarProducto().Show();
        }

        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IngresarCliente().Show();
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActualizarCliente().Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarCliente().Show();
        }

        private void ingresarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IngresarProveedor().Show();
            //this.Close();
            this.Visible = false;
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarProveedor().Show();
            this.Visible = false;
        }

        private void nombreDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new ConsultarNombreProducto().Show();
        }

        private void códigoDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new ConsultarCodigoProducto().Show();
        }

        private void rUCDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarRucProveedor().Show();
        }

        private void cédulaCiudadaníaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarCedulaCliente().Show();
        }

        private void nombreDeCiudadaníaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarNombreCliente().Show();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerarFactura().Show();
        }

        private void generarOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            IngresarMantenimiento im = new IngresarMantenimiento();
            im.Show();
            this.Close();
        }

        private void númeroDeTeléfonoConvencionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarTelefonoConvProveedor().Show();
            this.Visible = false;
        }

        private void razónSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarRazonSocialProveedor().Show();
            this.Visible = false;
        }

        private void correoElectrónicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarCorreoProveedor().Show();
            this.Visible = false;
        }

        private void fechaDeIncioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarFechaFinOrdenCompra().Show();
        }

        private void númeroDeOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarNumeroOrdenCompra().Show();
        }

        private void fechaDeExpediciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarFechaInicioOrdenCompra().Show();
        }

        private void númeroDeTélefonoCelularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarTelefonoCelularProveedor().Show();
            this.Visible = false;
        }

       

        private void cambiarEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarMantenimiento cm = new ConsultarMantenimiento();
            cm.Show();
            this.Close();
        }

        private void vehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IngresarProductoVehículo().Show();
        }

        private void manteniientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IngresarProductoMantenimiento().Show();
        }

        private void emitirFacturaElectrónicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmitirFacturaElectrónica().Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fechaDeEmisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarFactura().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generarNotaCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarNotaDeCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarNotaCredito().Show();
        }

        private void generarNotaDeCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerarNotaCredito().Show();
        }

        private void productoDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarMantenimiento().Show();
        }

        private void códigoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarCodigoProducto().Show();
        }

        private void nombreProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarNombreProducto().Show();
        }

        private void marcaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarProductoMarca().Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vehículoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EliminarVehiculo().Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarMarcaVehículo().Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarModeloVehículo().Show();
        }

        private void placaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarPlacaVehículo().Show();
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActualizarProducto().Show();
        }

        private void actualizarProductoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActualizarProductoMantenimiento().Show();
        }

        private void consultarOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmitirMantenimiento em = new EmitirMantenimiento();
            em.Show();
            this.Close();
        }

        private void generarNotaCréditoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarNotaCreditoMantenimiento gm = new GenerarNotaCreditoMantenimiento();
            gm.Show();
            this.Close();
        }

        private void generarReportesMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarReportesMantenimiento gm = new GenerarReportesMantenimiento();
            gm.Show();
            this.Close();
        }
    }
}
