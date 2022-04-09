using System;
using System.Windows.Forms;

namespace CajeroAutomatico1.pantallas
{
    public partial class GestionarClave : UserControl
    {
        private readonly Shell shell;

        public GestionarClave(Shell shell)
        {
            InitializeComponent();
            this.shell = shell;
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            shell.NavegarA("CambiarClave");
        }

        private void btnSolicClave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            shell.NavegarA("Desbloquear");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("autenticacion");
        }
    }
}
