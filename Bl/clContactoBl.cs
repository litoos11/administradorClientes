using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Dao;
using System.Data;

namespace Bl
{
    public class clContactoBl
    {
        private readonly clContactoDao contactoDao = new clContactoDao();

        public int crearNuevoContacto(clContactoEntity contacto)
        {
            int respuesta = contactoDao.crearNuevoContacto(contacto);
            return respuesta;
        } 

        public DataTable buscarContactosPorIdCliente(int idCliente)
        {
            DataTable dtContactos = contactoDao.buscarContactosPorIdCliente(idCliente);
            return dtContactos;
        }

        public int editarContacto(clContactoEntity contacto)
        {
            int respuesta = contactoDao.editarContacto(contacto);
            return respuesta;
        }

        public int eliminarContacto(int idContacto)
        {
            int respuesta = contactoDao.eliminarContacto(idContacto);
            return respuesta;
        }

    }
}
