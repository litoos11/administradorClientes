using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class clContactoEntity
    {
        public int idContacto { get; set; }
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string puesto { get; set; }
        public string correo { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaActualizacion { get; set; }

        public clContactoEntity(int idContacto, int idCliente, string nombre, string apellidoPaterno,
                                string apellidoMaterno, string telefono, string direccion, string puesto,
                                string correo, DateTime fechaAlta, DateTime fechaActualizacion)
        {
            this.idContacto = idContacto;
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.telefono = telefono;
            this.direccion = direccion;
            this.puesto = puesto;
            this.correo = correo;
            this.fechaAlta = fechaAlta;
            this.fechaActualizacion = fechaActualizacion;
        }

        public clContactoEntity()
        {
        }
    }
}
