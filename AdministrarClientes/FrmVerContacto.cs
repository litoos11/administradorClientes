using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace AdministrarClientes
{
    public partial class FrmVerContacto : Form
    {
        private clContactoEntity contacto = new clContactoEntity();

        public FrmVerContacto(clContactoEntity contacto)
        {
            InitializeComponent();
            this.contacto = contacto;
        }

        private void FrmVerContacto_Load(object sender, EventArgs e)
        {
            lblNombre.Text = contacto.nombre.ToUpper().TrimEnd() + " " + contacto.apellidoPaterno.ToUpper().TrimEnd() +
                           " " + contacto.apellidoMaterno.ToUpper().TrimEnd();
            lblTelefono.Text = contacto.telefono;
            lblCorreo.Text = contacto.correo.ToUpper().TrimEnd();
            lblPuesto.Text = contacto.puesto.ToUpper().TrimEnd();
            lblDireccion.Text = contacto.direccion.TrimEnd();
        }
    }
}
