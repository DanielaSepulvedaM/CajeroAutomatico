using CajeroAutomatico1.Dominio;
using System;
using System.Windows.Forms;

namespace CajeroAutomatico1.pantallas
{
    public partial class ConfirmacionRetiro : UserControl
    {
        private readonly Shell shell;

        int valorARetirar;

        public ConfirmacionRetiro(Shell shell)
        {
            InitializeComponent();
            this.shell = shell;

            var @params = shell.ObtenerParametros();

            valorARetirar = (int)@params["valor"];

            lblVlrRetirado.Text = valorARetirar.ToString("C");
            lblTotalRetiro.Text = valorARetirar.ToString("C");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("retiro");
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            var repo = shell.TransaccionRep;

            var cliente = (Cliente)shell.Context["cliente"];

            try
            {
                repo.Retirar(cliente.Cuenta.CuentaId, valorARetirar);
                shell.NavegarA("confirmacionretiro");
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
