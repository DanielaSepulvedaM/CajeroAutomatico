using System.ComponentModel.DataAnnotations.Schema;

namespace CajeroAutomatico1.Dominio
{
    [Table("Clientes")]
    public class Cliente
    {
        public string ClienteId { get; set; }
        public string Nombres { get; set; }
        public int Clave { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
