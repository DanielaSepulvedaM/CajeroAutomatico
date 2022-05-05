using CajeroAutomatico1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Repositorio
{
    public class CuentaRep
    {
        private readonly IBaseDeDatos db;

        public CuentaRep(IBaseDeDatos db)
        {
            this.db = db;
        }

        public int ObtenerCuentaId(string numero, string ident) {
            var cuenta = db.Cuentas.FirstOrDefault(c => c.ClienteId == ident && c.Numero == numero);
            return cuenta?.CuentaId ?? 0;
        }
    }
}
