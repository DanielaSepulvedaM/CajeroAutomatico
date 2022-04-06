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
    public partial class CambiarClave : UserControl
    {
        private readonly Shell shell;

        public CambiarClave(Shell shell)
        {
            InitializeComponent();
            this.shell = shell;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var frm = new GestionarClave(shell);
            shell.Mostrar(frm);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

        }
    }
}
