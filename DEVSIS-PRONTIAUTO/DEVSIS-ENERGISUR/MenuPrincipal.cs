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
            new RegistrarCliente().Show();
            this.Close();
        }

        private void actualizartelefonoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActualizarTeléfonoCelular().Show();
            this.Close();

        }
        private void actualizardireccionClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActualizarDireccionCliente().Show();
            this.Close();

        }

        private void actualizarcorreoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActualizarDireccionCorreoElectronico().Show();
            this.Close();

        }

        private void darDeBajaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DardeBajaCliente().Show();
            this.Close();
        }
        private void darDeAltaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DardeAltaCliente().Show();
            this.Close();

        }

        private void generarbackupClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerarCopiaSeguridadClientes().Show();
            this.Close();

        }

        private void emitirreporteClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmitirReporteClientes().Show();
            this.Close();

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

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarCliente().Show();
            this.Close();
        }

        

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerarFactura().Show();
            this.Close();
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
            new RegistrarVehículo().Show();
            this.Close();
        }

        private void manteniientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarVehículo().Show();
            this.Close();
        }

        private void emitirFacturaElectrónicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmitirFacturaElectrónica().Show();
            this.Close();
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
            this.Close();
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
            this.Close();
        }

        private void generarNotaDeCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerarNotaCredito().Show();
            this.Close();
        }

        private void productoDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarMantenimiento().Show();
            this.Close();
        }

        private void códigoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarCodigoProducto().Show();
            this.Close();
        }

        private void nombreProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new ConsultarNombreProducto().Show();
        }

        private void marcaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // new ConsultarProductoMarca().Show();
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
            new ConsultarVehículo().Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // new ConsultarModeloVehículo().Show();
        }

        private void placaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // new ConsultarPlacaVehículo().Show();
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IngresarProductoMantenimiento().Show();
            this.Close();
        }

        private void actualizarProductoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarCodigoProducto().Show();
            this.Close();
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

        private void actualizarVehículoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ActualizarVehiculo().Show();
            this.Close();
        }

        private void eliminarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarVehiculo().Show();
            this.Close();
        }

        private void actualizarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ActualizarProductoMantenimiento().Show();
            this.Close();
        }

        private void eliminarProductoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new EliminarMantenimiento().Show();
            this.Close();
        }

        private void registrarMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IngresarMantenimiento().Show();
            this.Close();
        }

        private void emitirMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmitirMantenimiento().Show();
            this.Close();
        }

        private void consultarMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarMantenimiento().Show();
            this.Close();
        }

        private void generarNotaDeCréditoDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerarNotaCreditoMantenimiento().Show();
            this.Close();
        }

        private void generarReportesDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarCita().Show();
            this.Close();
        }

        private void consultarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarCita().Show();
            this.Close();
        }

        private void generarReportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new GenerarReportesMantenimiento().Show();
            this.Close();
        }
    }
}
