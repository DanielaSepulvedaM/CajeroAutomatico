using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CajeroAutomatico1.Dominio
{
    [Table("Cuentas")]
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public string Numero { get; set; }
        public List<Transaccion> Transacciones { get; set; }

        public string ClienteId { get; set; }
    }
}
