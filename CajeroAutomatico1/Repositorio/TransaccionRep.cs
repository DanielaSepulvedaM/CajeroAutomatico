using CajeroAutomatico1.Dominio;
using CajeroAutomatico1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CajeroAutomatico1.Repositorio
{
    public class TransaccionRep
    {
        private readonly IBaseDeDatos db;

        public TransaccionRep(IBaseDeDatos db)
        {
            this.db = db;
        }
        public void Retirar(int cuentaId, decimal valor) {

            var saldoActual = SaldoActual(cuentaId);

            if (saldoActual - valor < 0)
                throw new ApplicationException("Saldo insuficiente");

            var transaccion = new Transaccion { 
                CuentaId = cuentaId,
                Fecha = DateTime.Now,
                Referencia = "Retiro por cajero automatico",
                Valor = valor * -1
            };

            db.Transacciones.Add(transaccion);
            db.SaveChanges();
        }

        public List<Transaccion> Transacciones(int cuentaId) {
            return db.Transacciones
                .Where(t => t.CuentaId == cuentaId)
                .OrderByDescending(t => t.Fecha)
                .Take(5)
                .ToList();
        }

        public decimal SaldoActual(int cuentaId) {
            var tran = db.Transacciones.Where(t => t.CuentaId == cuentaId).ToList();
            return tran.Sum(t => t.Valor);
        }

        public void Pago(int cuentaId, decimal valor, string referencia) {
            var transaccion = new Transaccion
            {
                CuentaId = cuentaId,
                Fecha = DateTime.Now,
                Referencia = $"Pago de servicio. Referencia: {referencia}",
                Valor = valor * -1
            };

            db.Transacciones.Add(transaccion);
            db.SaveChanges();
        }

        public void Transferir(int cuentaIdOrigen, int cuentaIdDestino, decimal valor)
        {
            var saldoActual = SaldoActual(cuentaIdOrigen);

            if (saldoActual - valor < 0)
                throw new ApplicationException("Saldos insuficientes");

            var cuentaOrigen = db.Cuentas.First(c => c.CuentaId == cuentaIdOrigen);
            var cuentaDestino = db.Cuentas.First(c => c.CuentaId == cuentaIdDestino);

            var debito = new Transaccion {
                CuentaId = cuentaIdOrigen,
                Fecha = DateTime.Now,
                Referencia = $"Transferencia bancaria a cuenta numero: {cuentaDestino.Numero}",
                Valor = -1 * valor
            };

            var credito = new Transaccion
            {
                CuentaId = cuentaIdDestino,
                Fecha = DateTime.Now,
                Referencia = $"Transferencia bancaria desde cuenta numero: {cuentaOrigen.Numero}",
                Valor = valor
            };

            db.Transacciones.AddRange(debito, credito);
            db.SaveChanges();
        }
    }
}
