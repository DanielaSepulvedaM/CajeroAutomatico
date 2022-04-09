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
            var clienteId = txtBxIdentificacionAcceso.Text;
            var clave = txtBxClave.Text;

            if (string.IsNullOrEmpty(clienteId) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Debe ingresar la identificacion del cliente y una contraseña válida");
                return;
            }

            var c = shell.ClienteRep.Autenticar(clienteId, int.Parse(clave));

            if (c is null)
                MessageBox.Show("Identificacion o clave no valida");
            else
            {
                this.shell.Context.Add("cliente", c);
                this.shell.NavegarA("menuprincipal");
            }   
        }

        private void btnGestionarClave_Click(object sender, EventArgs e)
        {
            this.shell.NavegarA("gestionarclave");
        }

        private void txtBxClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
