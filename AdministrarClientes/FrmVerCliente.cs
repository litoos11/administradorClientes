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
    public partial class FrmVerCliente : Form
    {

        private clClienteEntity cliente = new clClienteEntity();
        public FrmVerCliente(clClienteEntity cliente) {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void FrmVerCliente_Load(object sender, EventArgs e) {
            lblRazon.Text = cliente.razonSocial.ToUpper().TrimEnd();
            lblNombre.Text = cliente.nombreComercial.ToUpper().TrimEnd();
            lblRfc.Text = cliente.rfc.ToUpper();
            lblCurp.Text = cliente.curp.ToUpper();
            lblTelefono.Text = cliente.telefono;
            lblCorreo.Text = !string.IsNullOrEmpty(cliente.correo) ? cliente.correo : "---";
            lblDireccion.Text = cliente.direccion.ToUpper();
        }

        private void btnVerContactos_Click(object sender, EventArgs e) {

        }

    }
}
