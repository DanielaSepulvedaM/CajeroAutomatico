using System;
using System.Windows.Forms;

namespace CajeroAutomatico1.pantallas
{
    public partial class PantallaTransaccionExitosa : UserControl
    {
        private readonly Shell shell;

        public PantallaTransaccionExitosa(Shell shell)
        {
            InitializeComponent();
            this.shell = shell;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("autenticacion");
        }
    }
}
