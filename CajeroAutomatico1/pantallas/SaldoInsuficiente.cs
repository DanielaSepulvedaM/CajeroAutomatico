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
    public partial class PantallaFinalRetiro : UserControl
    {
        private readonly Shell shell;

        public PantallaFinalRetiro(Shell shell)
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
