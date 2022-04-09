using CajeroAutomatico1.Dominio;
using CajeroAutomatico1.Interfaces;
using System.Collections.Generic;

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
        
        }

        public List<Transaccion> Transacciones() {
            return null;
        }

        public decimal SaldoActual() {
            return 0;
        }

        public void Pago(decimal valor, string referencia) { 
            
        }
    }
}
