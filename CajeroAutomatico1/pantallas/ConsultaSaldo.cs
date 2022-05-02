﻿using CajeroAutomatico1.Dominio;
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
    public partial class ConsultaSaldo : UserControl
    {
        private readonly Shell shell;

        public ConsultaSaldo(Shell shell)
        {
            InitializeComponent();
            this.shell = shell;

            var repo = shell.TransaccionRep;

            var cliente = (Cliente)shell.Context["cliente"];

            var saldo = repo.SaldoActual(cliente.Cuenta.CuentaId);

            lblSaldoActual.Text = saldo.ToString("C");
            lblTotal.Text = saldo.ToString("C");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("menuprincipal");
        }
    }
}
