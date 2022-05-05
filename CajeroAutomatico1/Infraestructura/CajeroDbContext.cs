using CajeroAutomatico1.Dominio;
using CajeroAutomatico1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CajeroAutomatico1.Infraestructura
{
    public class CajeroDbContext : DbContext, IBaseDeDatos
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }

        public string DbPath { get; }

        public CajeroDbContext()
        {
            var path = Environment.CurrentDirectory;
            DbPath = System.IO.Path.Combine(path, "cajero.db");

            Database.EnsureCreated();

            //Database.Migrate();

            Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

        public void Seed() {
            if (!this.Clientes.Any()) {
                var c1 = new Cliente { Nombres = "John el esquizofrenico", Clave = 1234, ClienteId = "1018420217" };
                var c2 = new Cliente { Nombres = "Ingri", Clave = 5678, ClienteId = "1010215846" };

                this.Clientes.AddRange(c1, c2);
                this.SaveChanges();

                var cu1 = new Cuenta { ClienteId = "1018420217", CuentaId = 1, Numero = "00491022" };
                var cu2 = new Cuenta { ClienteId = "1010215846", CuentaId = 2, Numero = "00125699" };
                this.Cuentas.AddRange(cu1, cu2);

                this.SaveChanges();

                var t = new Transaccion { CuentaId = 1, Fecha = DateTime.Today, Referencia = "Saldo inicial", TransaccionId = 1, Valor = 100000 };
                this.Transacciones.Add(t);

                this.SaveChanges();
            }
        }

        void IBaseDeDatos.SaveChanges()
        {
            this.SaveChanges();
        }
    }
}
