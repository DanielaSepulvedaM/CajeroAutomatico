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
    public partial class Consultas : UserControl
    {
        private readonly Shell shell;

        public Consultas(Shell shell)
        {
            InitializeComponent();
            this.shell = shell;
        }

        private void btnConslExt_Click(object sender, EventArgs e)
        {
            shell.NavegarA("consultasaldo");
        }

        private void btnConslMov_Click(object sender, EventArgs e)
        {
            shell.NavegarA("consultamovimientos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("menuprincipal");
        }
    }
}
