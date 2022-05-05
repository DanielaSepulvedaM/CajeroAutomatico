using CajeroAutomatico1.Dominio;
using CajeroAutomatico1.Infraestructura;
using CajeroAutomatico1.Interfaces;
using CajeroAutomatico1.pantallas;
using CajeroAutomatico1.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Routing;
using System.Windows.Forms;

namespace CajeroAutomatico1
{
    public partial class Shell : Form
    {
        private readonly IBaseDeDatos db;

        public ClienteRep ClienteRep { get; internal set; } 

        public TransaccionRep TransaccionRep { get; internal set; }

        public CuentaRep CuentaRep { get; internal set; }

        public Dictionary<string, object> Context { get; internal set; }

        public Shell()
        {
            InitializeComponent();

            db = new CajeroDbContext();

            ClienteRep = new ClienteRep(db);
            TransaccionRep = new TransaccionRep(db);
            CuentaRep = new CuentaRep(db);

            Context = new Dictionary<string, object>();

            var formAuth = new Autenticacion(this);
            this.Controls.Add(formAuth);
        }


        public void NavegarA(string vista, object parametros = null)
        {
            if (parametros != null)
                SetRouteParam(parametros);
            else
                ClearRouteParam();

            if (vistas.TryGetValue(vista.ToLower(), out var form))
                Mostrar(form(this));
            else
                Mostrar(new Error(this));
        }

        public RouteValueDictionary ObtenerParametros() {
            if (!Context.ContainsKey("route"))
                return null;

            var p = ((RouteValueDictionary)Context["route"]);
            Context.Remove("route");
            return p;
        }

        private void SetRouteParam(object parametros) {
            if (Context.ContainsKey("route"))
                Context["route"] = new RouteValueDictionary(parametros);
            else
                Context.Add("route", new RouteValueDictionary(parametros));
        }

        private void ClearRouteParam() {
            if (Context.ContainsKey("route"))
                Context.Remove("route");
        }

        private void RemoverVistaActiva() {
            var frm = this.Controls.Cast<Control>().First();
            this.Controls.Remove(frm);
            frm.Dispose();
        }

        private void Mostrar(UserControl ctrl) {
            RemoverVistaActiva();
            this.Controls.Add(ctrl);
        }

        private void LimpiarSesion() {
            this.Context.Clear();
        }

        private Dictionary<string, Func<Shell, UserControl>> vistas => new Dictionary<string, Func<Shell, UserControl>> {
            { "autenticacion", (shell) => {
                LimpiarSesion();
                return new Autenticacion(shell);
            } },
            { "cambiarclave", (shell) => new CambiarClave(shell) },
            { "confirmacionretiro", (shell) => new ConfirmacionRetiro(shell) },
            { "desbloquear", (shell) => new Desbloquear(shell) },
            { "gestionarclave", (shell) => new GestionarClave(shell)},
            { "menuprincipal", (shell) => new MenuPrincipal(shell) },
            { "pagarfactura", (shell) => new PagarFacturas(shell) },
            { "pantallafinalretiro", (shell) => new PantallaFinalRetiro(shell)},
            { "pantallasemifinalpagofactura", (shell) => new PantallaSemiFinalPagoFactura(shell) },
            { "transaccionexitosa", (shell) => new PantallaTransaccionExitosa(shell) },
            { "retiro", (shell) => new Retiros(shell) },
            { "transferencia", (shell) => new Transferencia(shell) },
            { "error", (shell) => new Error(shell) },
            { "menuconsultas", (shell) => new Consultas(shell) },
            { "consultamovimientos", (shell) => new ConsultaMovimientos(shell) },
            { "consultasaldo", shell => new ConsultaSaldo(shell) }
        };

        private void Shell_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}
