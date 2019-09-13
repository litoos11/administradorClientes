using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bl;
using Entity;

namespace AdministrarClientes
{
    public partial class FrmVerContactosDeCliente : Form
    {
        private readonly clContactoBl contactoBl = new clContactoBl();
        private int idCliente;

        public FrmVerContactosDeCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
        }

        private void FrmVerContactorDeCliente_Load(object sender, EventArgs e)
        {
            DataTable dtContactos = contactoBl.buscarContactosPorIdCliente(idCliente);
            llenaGridContactos(dtContactos);
        }

        private void llenaGridContactos(DataTable dtContactos)
        {
            dgvContactos.DataSource = dtContactos;
            if(dgvContactos.Rows.Count > 0)
            {
                dgvContactos.Columns["IDCONTACTO"].Visible = false;
                dgvContactos.Columns["IDCLIENTE"].Visible = false;
                dgvContactos.Columns["DIRECCION"].Visible = false;
                dgvContactos.Columns["CORREO"].Visible = false;
                dgvContactos.Columns["PUESTO"].Visible = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clContactoEntity editarContacto = new clContactoEntity();
            DataGridViewRow row = dgvContactos.CurrentRow;

            if(row == null)
            {
                return;
            }

            editarContacto.idContacto = Convert.ToInt32(row.Cells["IDCONTACTO"].Value.ToString());
            editarContacto.idCliente = Convert.ToInt32(row.Cells["IDCLIENTE"].Value.ToString());
            editarContacto.nombre = row.Cells["NOMBRE"].Value.ToString().TrimEnd();
            editarContacto.apellidoPaterno = row.Cells["PATERNO"].Value.ToString().TrimEnd();
            editarContacto.apellidoMaterno = !string.IsNullOrEmpty(row.Cells["MATERNO"].Value.ToString()) ? row.Cells["MATERNO"].Value.ToString().TrimEnd() : string.Empty;
            editarContacto.telefono = row.Cells["TELEFONO"].Value.ToString();
            editarContacto.direccion = row.Cells["DIRECCION"].Value.ToString().TrimEnd();
            editarContacto.puesto = row.Cells["PUESTO"].Value.ToString().TrimEnd();
            editarContacto.correo = !string.IsNullOrEmpty(row.Cells["CORREO"].Value.ToString()) ? row.Cells["CORREO"].Value.ToString().TrimEnd() : string.Empty;

            FrmFormContacto frmFormContacto = new FrmFormContacto(false, editarContacto, editarContacto.idCliente);
            frmFormContacto.ShowDialog();
        }

        private void dgvContactos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow row = e.Row;
            int idContacto = Convert.ToInt16(row.Cells[0].Value.ToString());

            DialogResult respuestaMsgBox = MessageBox.Show("¿Eliminar el contacto de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuestaMsgBox.Equals(DialogResult.No))
            {
                e.Cancel = true;
                return;
            }

            int respuesta = contactoBl.eliminarContacto(idContacto);

            if (respuesta != 1)
            {
                MessageBox.Show("Ocurrio un error al eliminar el contacto, intente de nuevo!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            MessageBox.Show("Contacto eliminador correctamente!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void dgvContactos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clContactoEntity verContacto = new clContactoEntity();
            DataGridView grid = (DataGridView)sender;

            if (e.RowIndex < 0) return;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    verContacto.idContacto = Convert.ToInt32(row.Cells["IDCONTACTO"].Value.ToString());
                    verContacto.idCliente = Convert.ToInt32(row.Cells["IDCLIENTE"].Value.ToString());
                    verContacto.nombre = row.Cells["NOMBRE"].Value.ToString().TrimEnd();
                    verContacto.apellidoPaterno = row.Cells["PATERNO"].Value.ToString().TrimEnd();
                    verContacto.apellidoMaterno = !string.IsNullOrEmpty(row.Cells["MATERNO"].Value.ToString()) ? row.Cells["MATERNO"].Value.ToString().TrimEnd() : string.Empty;
                    verContacto.telefono = row.Cells["TELEFONO"].Value.ToString();
                    verContacto.direccion = row.Cells["DIRECCION"].Value.ToString().TrimEnd();
                    verContacto.puesto = row.Cells["PUESTO"].Value.ToString().TrimEnd();
                    verContacto.correo = !string.IsNullOrEmpty(row.Cells["CORREO"].Value.ToString()) ? row.Cells["CORREO"].Value.ToString().TrimEnd() : string.Empty;
                                        
                }
            }
            FrmVerContacto frmVerContacto = new FrmVerContacto(verContacto);
            frmVerContacto.ShowDialog();
        }
    }
}
