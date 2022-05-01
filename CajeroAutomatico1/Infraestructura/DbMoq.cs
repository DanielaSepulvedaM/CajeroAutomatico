using CajeroAutomatico1.Dominio;
using CajeroAutomatico1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CajeroAutomatico1.Infraestructura
{
    public class DbMoq : IBaseDeDatos
    {
        public DbSet<Cliente> Clientes { get; internal set; }

        public DbSet<Cuenta> Cuentas { get; internal set; }

        public DbSet<Transaccion> Transacciones { get;  internal set; }

        public DbMoq()
        {
            Clientes.Add(new Cliente { Nombres = "John el esquizofrenico", Clave = 1234, ClienteId = "1018420217" });

            Cuentas.Add(new Cuenta { ClienteId = "1018420217", CuentaId = 1, Numero = "00491022" });

            Transacciones.Add(new Transaccion { CuentaId = 1, Fecha = DateTime.Today, Referencia = "Saldo inicial", TransaccionId = 1, Valor = 100000 });
        }

        public void SaveChanges()
        {
            
        }

        public void Dispose()
        {
            
        }
    }
}
