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
    public partial class Autenticacion : UserControl
    {
        private readonly Shell shell;

        public Autenticacion(Shell shell)
        {
            InitializeComponent();
            this.shell = shell;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var frm = new MenuPrincipal(shell);
            this.shell.Mostrar(frm);
        }

        private void btnGestionarClave_Click(object sender, EventArgs e)
        {
            var frm = new GestionarClave(shell);
            this.shell.Mostrar(frm);
        }
    }
}
