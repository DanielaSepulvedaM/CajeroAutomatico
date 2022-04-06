using CajeroAutomatico1.pantallas;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CajeroAutomatico1
{
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
            var formAuth = new Autenticacion(this);
            this.Controls.Add(formAuth);
        }

        private void RemoverVistaActiva() {
            var frm = this.Controls.Cast<Control>().First();
            this.Controls.Remove(frm);
            frm.Dispose();
        }

        public void Mostrar(UserControl ctrl) {
            RemoverVistaActiva();
            this.Controls.Add(ctrl);
        }
    }
}
