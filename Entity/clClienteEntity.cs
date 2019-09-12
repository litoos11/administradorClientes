using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class clClienteEntity
    {

        public int idCliente { get; set; }
        public string nombreComercial { get; set; }
        public string razonSocial { get; set; }        
        public string rfc { get; set; }
        public string curp { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaActualizacion { get; set; }

        public clClienteEntity(int idCliente, string nombreComercial, string razonSocial, string rfc, string curp, string telefono, string direccion, DateTime fechaAlta, DateTime fechaActualizacion)
        {
            this.idCliente = idCliente;
            this.nombreComercial = nombreComercial;
            this.razonSocial = razonSocial;
            this.rfc = rfc;
            this.curp = curp;
            this.telefono = telefono;
            this.direccion = direccion;
            this.fechaAlta = fechaAlta;
            this.fechaActualizacion = fechaActualizacion;
        }

        public clClienteEntity() { }
    }
}
