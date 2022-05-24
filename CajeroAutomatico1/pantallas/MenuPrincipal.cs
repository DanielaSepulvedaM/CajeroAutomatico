using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico1.pantallas
{
    public partial class MenuPrincipal : UserControl
    {
        private readonly Shell shell;

        public MenuPrincipal(Shell shell)
        {
            InitializeComponent();
            this.shell = shell;
        }

        private void btnRetiros_Click(object sender, EventArgs e)
        {
            shell.NavegarA("retiro");
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            shell.NavegarA("transferencia");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            shell.NavegarA("autenticacion");
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            shell.NavegarA("menuconsultas");
        }

        private void btnPagarFactura_Click(object sender, EventArgs e)
        {
            shell.NavegarA("pagarfactura");
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            shell.NavegarA("cambiarclave");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("autenticacion");
        }
    }
}
