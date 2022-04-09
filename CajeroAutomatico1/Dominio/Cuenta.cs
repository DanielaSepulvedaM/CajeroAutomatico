using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Dominio
{
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public string Numero { get; set; }
        public List<Transaccion> Transacciones { get; set; }

        public string ClienteId { get; set; }
    }
}
