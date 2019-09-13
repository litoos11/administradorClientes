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
using Entity;

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
            DataTable dtClientes = clienteBl.buscarClientes();
            llenaGridClientes(dtClientes);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtClientes = new DataTable();
            if (string.IsNullOrEmpty(txtBucar.Text))
            {          
                dtClientes = clienteBl.buscarClientes();
            } else {
                dtClientes = clienteBl.buscarClientesPorNombre(txtBucar.Text);                
            }

            llenaGridClientes(dtClientes);                    
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clClienteEntity cliente = new clClienteEntity();
            FrmFormCliente frmCliente = new FrmFormCliente(true, cliente);
            frmCliente.ShowDialog();
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            clClienteEntity verCliente = new clClienteEntity();
            DataGridView grid = (DataGridView)sender;
            if (e.RowIndex < 0) return;

            foreach(DataGridViewRow row in grid.Rows) {
                if(row.Index == e.RowIndex) {
                    verCliente.idCliente = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    verCliente.razonSocial = row.Cells["RAZON"].Value.ToString();
                    verCliente.nombreComercial = row.Cells["NOMBRE"].Value.ToString();
                    verCliente.rfc = row.Cells["RFC"].Value.ToString();
                    verCliente.curp = row.Cells["CURP"].Value.ToString();
                    verCliente.telefono = row.Cells["TELEFONO"].Value.ToString();
                    verCliente.correo = row.Cells["CORREO"].Value.ToString();
                    verCliente.direccion = row.Cells["DIRECCION"].Value.ToString();
                }
            }

            FrmVerCliente frmVerCliente = new FrmVerCliente(verCliente);
            frmVerCliente.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            clClienteEntity editarCliente = new clClienteEntity();
            DataGridView grid = dgvClientes;       

            DataGridViewRow row = grid.CurrentRow;

            if(row == null) {
                return;
            }
            editarCliente.idCliente = Convert.ToInt32(row.Cells["ID"].Value.ToString());
            editarCliente.razonSocial = row.Cells["RAZON"].Value.ToString().TrimEnd();
            editarCliente.nombreComercial = row.Cells["NOMBRE"].Value.ToString().TrimEnd();
            editarCliente.rfc = row.Cells["RFC"].Value.ToString();
            editarCliente.curp = row.Cells["CURP"].Value.ToString();
            editarCliente.telefono = row.Cells["TELEFONO"].Value.ToString();
            editarCliente.correo = !string.IsNullOrEmpty(row.Cells["CORREO"].Value.ToString()) ? row.Cells["CORREO"].Value.ToString() : string.Empty;
            editarCliente.direccion = row.Cells["DIRECCION"].Value.ToString();

            FrmFormCliente frmCliente = new FrmFormCliente(false, editarCliente);
            frmCliente.ShowDialog();
        }

        private void dgvClientes_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            DataGridViewRow row = e.Row;
            int idCliente =Convert.ToInt16(row.Cells[0].Value.ToString());

            DialogResult respuestaMsgBox = MessageBox.Show("¿Eliminar el cliente de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuestaMsgBox.Equals(DialogResult.No)) {
                e.Cancel = true;
                return;
            }

            int respuesta = clienteBl.eliminarCliente(idCliente);

            if (respuesta != 1) {
                MessageBox.Show("Ocurrio un error al eliminar el cliente, intente de nuevo!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            MessageBox.Show("Cliente eliminador correctamente!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void llenaGridClientes(DataTable dtClientes)
        {

            dgvClientes.DataSource = dtClientes;
            if (dgvClientes.Rows.Count > 0)
            {
                dgvClientes.Columns["ID"].Visible = false;
                dgvClientes.Columns["DIRECCION"].Visible = false;
                dgvClientes.Columns["CORREO"].Visible = false;
                dgvClientes.Columns["TELEFONO"].Visible = false;
            }
        }
    }
}
