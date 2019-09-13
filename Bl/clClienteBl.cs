using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using System.Data;
using Entity;

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

        public int crearClienteNuevo(clClienteEntity cliente) {
            int respuesta = clienteDao.crearNuevoCliente(cliente);
            return respuesta;
        }

        public int editarCliente(clClienteEntity cliente) {
            int respuesta = clienteDao.editarCliente(cliente);
            return respuesta;
        }

        public int eliminarCliente(int idCliente) {
            int respuesta = clienteDao.eliminarCliente(idCliente);
            return respuesta;
        }
       
    }
}
