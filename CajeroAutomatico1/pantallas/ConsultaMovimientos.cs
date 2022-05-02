using CajeroAutomatico1.Dominio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CajeroAutomatico1.pantallas
{
    public partial class ConsultaMovimientos : UserControl
    {
        private readonly Shell shell;

        const int offset = 18;
        const int initTabIdx = 43;

        public ConsultaMovimientos(Shell shell)
        {
            InitializeComponent();
            this.shell = shell;

            var cliente = (Cliente)shell.Context["cliente"];

            var transacciones = shell.TransaccionRep.Transacciones(cliente.Cuenta.CuentaId);

            for (int i = 0; i < transacciones.Count; i++)
            {
                var t = transacciones[i];
                SetNum(i);
                SetFecha(i, t.Fecha);
                SetDescrip(i, t.Referencia);
                SetValor(i, t.Valor);
            }

            pictureBox1.SendToBack();
            Refresh();
        }

        private void SetNum(int i)
        {
            var l = new Label();

            l.AutoSize = true;
            l.Location = new Point(96, 188+i*offset);
            l.Name = $"lblNum{i}";
            l.Size = new Size(35, 13);
            l.TabIndex = initTabIdx+i*4;
            l.Text = $"{i + 1}";
           
            AddControl(l);
        }

        private void SetFecha(int i, DateTime fecha) {

            var l = new Label();

            l.AutoSize = true;
            l.Location = new System.Drawing.Point(170, 188+i*offset);
            l.MaximumSize = new System.Drawing.Size(100, 0);
            l.Name = "lblFecha" + i;
            l.Size = new System.Drawing.Size(35, 13);
            l.TabIndex = initTabIdx+i*4+1;
            l.Text = fecha.ToShortDateString();

            AddControl(l);
        }

        private void SetDescrip(int i, string desc) {

            var l = new Label();

            l.AutoSize = true;
            l.Location = new System.Drawing.Point(324, 188+i*offset);
            l.MaximumSize = new System.Drawing.Size(200, 0);
            l.Name = "lblDescripcion"+i;
            l.Size = new System.Drawing.Size(199, 39);
            l.TabIndex = initTabIdx+i*4+2;
            l.Text = desc;

            AddControl(l);
        }

        private void SetValor(int i, decimal valor) {
            var l = new Label();

            l.AutoSize = true;
            l.Location = new System.Drawing.Point(600, 188+i*offset);
            l.Name = "lblValor"+i;
            l.Size = new System.Drawing.Size(35, 13);
            l.TabIndex = initTabIdx+i*4+3;
            l.Text = valor.ToString("C");

            AddControl(l);
        }

        private void AddControl(Control control) {
            this.Controls.Add(control);
        }
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            shell.NavegarA("menuprincipal");
        }
    }
}
