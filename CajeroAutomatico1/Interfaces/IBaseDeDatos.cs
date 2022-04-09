using CajeroAutomatico1.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Interfaces
{
    public interface IBaseDeDatos
    {
        List<Cliente> Clientes { get; }
        List<Cuenta> Cuentas { get;  }
        List<Transaccion> Transacciones { get; }

        void SaveChanges();
    }
}
