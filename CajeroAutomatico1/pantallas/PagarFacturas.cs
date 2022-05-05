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
    public partial class PagarFacturas : UserControl
    {
        private readonly Shell shell;

        private Dictionary<string, Convenio> convenios;

        public PagarFacturas(Shell shell)
        {
            InitializeComponent();
            this.shell = shell;

            convenios = new Dictionary<string, Convenio> {
                { "etbab00", new Convenio(70000, "Empresas Publicas de bogota")  },
                { "cl1234", new Convenio(120000, "Claro Telefonia Móvil")  },
                { "en456", new Convenio(95000, "Enel Codensa") }
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("menuprincipal");
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConvenio.Text))
            {
                MessageBox.Show("Ingrese un numero de convenio");
                return;
            }

            if (!convenios.ContainsKey(txtConvenio.Text))
            {
                MessageBox.Show("Convenio no existe");
                return;
            }

            var param = new { 
                valor = convenios[txtConvenio.Text].Valor,
                descripcion = convenios[txtConvenio.Text].Descripcion
            };

            shell.NavegarA("confirmarpago", param);
        }

        class Convenio
        {
            public decimal Valor { get; set; }
            public string Descripcion { get; set; }

            public Convenio(decimal valor, string desc)
            {
                this.Valor = valor;
                this.Descripcion = desc;
            }
        }
    }
}
