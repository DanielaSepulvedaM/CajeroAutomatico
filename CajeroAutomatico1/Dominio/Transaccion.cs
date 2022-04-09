using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Dominio
{
    public class Transaccion
    {
        public long TransaccionId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }

        public int CuentaId { get; set; }
    }
}
