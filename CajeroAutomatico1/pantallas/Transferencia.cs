using CajeroAutomatico1.Dominio;
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
    public partial class Transferencia : UserControl
    {
        private readonly Shell shell;

        public Transferencia(Shell shell)
        {
            InitializeComponent();

            txtIdentificacion.KeyPress += OnKeyPress;
            txtCuenta.KeyPress += OnKeyPress;
            txtValor.KeyPress += OnKeyPress;

            this.shell = shell;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("menuprincipal");
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuenta.Text) || string.IsNullOrEmpty(txtIdentificacion.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Diligencie toda la informacion necesaria");
                return;
            }

            var cuentaId = shell.CuentaRep.ObtenerCuentaId(txtCuenta.Text, txtIdentificacion.Text);
            if (cuentaId == 0) {
                MessageBox.Show("Cuenta destinatario no es valida. Verifique los datos");
                return;
            }

            var cliente = (Cliente)shell.Context["cliente"];

            try
            {
                shell.TransaccionRep.Transferir(cliente.Cuenta.CuentaId, cuentaId, decimal.Parse(txtValor.Text));
            }
            catch (ApplicationException ex) { 
                
            }
            catch (Exception)
            {
                shell.NavegarA("error");
            }
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
