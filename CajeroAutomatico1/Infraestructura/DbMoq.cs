using CajeroAutomatico1.Dominio;
using CajeroAutomatico1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Infraestructura
{
    public class DbMoq : IBaseDeDatos
    {
        public List<Cliente> Clientes { get; internal set; }

        public List<Cuenta> Cuentas { get; internal set; }

        public List<Transaccion> Transacciones { get;  internal set; }

        public DbMoq()
        {
            Clientes = new List<Cliente> { 
                new Cliente { Nombres = "John el esquizofrenico", Clave = 1234, ClienteId = "1018420217" }
            };

            Cuentas = new List<Cuenta> { 
                new Cuenta { ClienteId = "1018420217", CuentaId = 1, Numero = "00491022" }
            };

            Transacciones = new List<Transaccion> {
                new Transaccion { CuentaId = 1, Fecha = DateTime.Today, Referencia = "Saldo inicial", TransaccionId = 1, Valor = 100000 }
            };
        }

        public void SaveChanges()
        {
            
        }
    }
}
