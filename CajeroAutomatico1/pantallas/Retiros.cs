using System;
using System.Windows.Forms;

namespace CajeroAutomatico1.pantallas
{
    public partial class Retiros : UserControl
    {
        private readonly Shell shell;

        public Retiros(Shell shell)
        {
            InitializeComponent();

            btnVlr1.Click += ValorFijo_Click;
            btnVlr2.Click += ValorFijo_Click;
            btnVlr3.Click += ValorFijo_Click;
            btnVlr4.Click += ValorFijo_Click;
            btnVlr5.Click += ValorFijo_Click;
            btnVlr6.Click += ValorFijo_Click;
            btnVlr7.Click += ValorFijo_Click;

            this.shell = shell;
        }

        private void ValorFijo_Click(object sender, EventArgs e)
        {
            var cantidad = int.Parse(((Button)sender).Tag.ToString());

            shell.NavegarA("confirmacionretiro", new { valor = cantidad });
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("menuprincipal");
        }

        private void btnSumaDiferente_Click(object sender, EventArgs e)
        {

        }
    }
}
