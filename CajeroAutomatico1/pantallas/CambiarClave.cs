using CajeroAutomatico1.Dominio;
using System;
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

            txtClaveActual.KeyPress += SoloNumeros;
            txtClaveNueva.KeyPress += SoloNumeros;
            txtClaveNuevaConf.KeyPress += SoloNumeros;
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("menuprincipal");
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            var claveActual = txtClaveActual.Text;
            var claveNueva = txtClaveNueva.Text;
            var claveNuevaConf = txtClaveNuevaConf.Text;

            if (string.IsNullOrWhiteSpace(claveActual) || string.IsNullOrWhiteSpace(claveNueva) || string.IsNullOrWhiteSpace(claveNuevaConf))
            {
                MessageBox.Show("Debe diligenciar todos los campoos");
                return;
            }

            if (claveNueva.Length != 4) {
                MessageBox.Show("Clave debe ser de 4 digitos");
                return;
            }

            if (!claveNueva.Equals(claveNuevaConf))
            {
                MessageBox.Show("Claves nuevas no coinciden");
                return;
            }

            var cliente = (Cliente)shell.Context["cliente"];

            try
            {
                shell.ClienteRep.CambiarClave(cliente.ClienteId, int.Parse(claveActual), int.Parse(claveNueva));
                shell.NavegarA("transaccionexitosa");
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                shell.NavegarA("error");
            }
        }
    }
}
