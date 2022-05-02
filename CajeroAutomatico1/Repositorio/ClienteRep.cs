using CajeroAutomatico1.Dominio;
using CajeroAutomatico1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico1.Repositorio
{
    public class ClienteRep
    {
        private readonly IBaseDeDatos db;

        public ClienteRep(IBaseDeDatos db)
        {
            this.db = db;
        }

        public Cliente Autenticar(string identificacion, int clave) {

            return db.Clientes.Include(c => c.Cuenta).FirstOrDefault(c => c.ClienteId == identificacion && c.Clave == clave);
        }

        public void CambiarClave(string identificacion, int claveActual, int nuevaClave) { 
            var cliente = db.Clientes.FirstOrDefault(c => c.ClienteId == identificacion && c.Clave == claveActual);

            if (cliente is null)
                throw new ApplicationException("Clave actual inválida");

            cliente.Clave = nuevaClave;

            db.SaveChanges();
        }
    }
}
