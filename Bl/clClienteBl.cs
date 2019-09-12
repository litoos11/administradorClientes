using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using System.Data;

namespace Bl
{
    public class clClienteBl
    {
        private clClienteDao clienteDao = new clClienteDao();

        public DataTable buscarClientes()
        {
            return clienteDao.buscarClientes();
        }

        public DataTable buscarClientesPorNombre(string nombre)
        {
            return clienteDao.buscarClientesPorNombre(nombre);
        }
    }
}
