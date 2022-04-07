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
            var frm = new Retiros(shell);
            shell.Mostrar(frm);
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            var frm = new Transferencia(shell);
            shell.Mostrar(frm);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
