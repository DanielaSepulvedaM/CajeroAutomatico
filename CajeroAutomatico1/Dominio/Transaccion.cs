using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CajeroAutomatico1.Dominio
{
    [Table("Transacciones")]
    public class Transaccion
    {
        public long TransaccionId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }

        public int CuentaId { get; set; }
    }
}
