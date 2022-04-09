using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Dominio
{
    public class Cliente
    {
        public string ClienteId { get; set; }
        public string Nombres { get; set; }
        public int Clave { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
