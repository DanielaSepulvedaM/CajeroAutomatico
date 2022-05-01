using CajeroAutomatico1.Dominio;
using Microsoft.EntityFrameworkCore;
using System;

namespace CajeroAutomatico1.Interfaces
{
    public interface IBaseDeDatos : IDisposable
    {
        DbSet<Cliente> Clientes { get; }
        DbSet<Cuenta> Cuentas { get;  }
        DbSet<Transaccion> Transacciones { get; }

        void SaveChanges();
    }
}
