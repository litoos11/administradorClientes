using Bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrarClientes
{
    public partial class FrmClientes : Form
    {
        private readonly clClienteBl clienteBl = new clClienteBl();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clienteBl.buscarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBucar.Text))
            {
                MessageBox.Show("Introduce el nombre del cliente ha buscar!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //dgvClientes.Rows.Clear();
            dgvClientes.DataSource = clienteBl.buscarClientesPorNombre(txtBucar.Text);
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmFormCliente frmCliente = new FrmFormCliente(false);
            frmCliente.Show();


        }
    }
}
