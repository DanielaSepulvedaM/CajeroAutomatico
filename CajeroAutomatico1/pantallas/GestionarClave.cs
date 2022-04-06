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
            var frm = new CambiarClave(shell);
            shell.Mostrar(frm);
        }

        private void btnSolicClave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            var frm = new Desbloquear(shell);
            shell.Mostrar(frm);
        }
    }
}
