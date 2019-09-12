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
    public partial class FrmFormCliente : Form
    {
        private bool isNuevo;
        private clClienteEntity cliente;
        private readonly clClienteBl clienteBl = new clClienteBl();


        public FrmFormCliente(bool isNuevo, clClienteEntity cliente)
        {
            InitializeComponent();
            this.isNuevo = isNuevo;
            this.cliente = cliente;
            
        }

        private void FrmFormCliente_Load(object sender, EventArgs e)
        {
            lblAccion.Text = (isNuevo) ? "Nuevo" : "Editar";
            llenaFormulario();            
        }

        private void llenaFormulario() {
            txtRazon.Text = cliente.razonSocial;
            txtNombre.Text = cliente.nombreComercial;
            txtRfc.Text = cliente.rfc;
            txtCurp.Text = cliente.curp;
            txtTelefono.Text = cliente.telefono;
            txtCorreo.Text = cliente.correo;
            txtDireccion.Text = cliente.direccion;
        }

        private void btnGurdar_Click(object sender, EventArgs e) {
            if (!isValido()) {
                MessageBox.Show("Los campos con ** son obligatorios!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int telefono;
            if(int.TryParse(txtTelefono.Text, out telefono)) {
                MessageBox.Show("Número de telefono debe ser solo numeros: ejemplo 2292194912.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isNuevo) {
                gurdarCliente();
            } else {
                actualizarCliente();
            }
        }

        private void actualizarCliente() {
            cliente.razonSocial = txtRazon.Text;
            cliente.nombreComercial = txtNombre.Text;
            cliente.rfc = txtRfc.Text.ToUpper();
            cliente.curp = txtCurp.Text.ToUpper();
            cliente.telefono = txtTelefono.Text;
            cliente.correo = txtCorreo.Text.ToUpper();
            cliente.direccion = txtDireccion.Text;

            int respuesta = clienteBl.editarCliente(cliente);
            if (respuesta != 1) {
                MessageBox.Show("Ocurrio un error al editar el cliente, intente de nuevo!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cliente editado correctamente!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void gurdarCliente() {
            cliente.razonSocial = txtRazon.Text;
            cliente.nombreComercial = txtNombre.Text;
            cliente.rfc = txtRfc.Text.ToUpper();
            cliente.curp = txtCurp.Text.ToUpper();
            cliente.telefono = txtTelefono.Text;
            cliente.correo = txtCorreo.Text.ToUpper();
            cliente.direccion = txtDireccion.Text;            

            int respuesta = clienteBl.crearClienteNuevo(cliente);
            if(respuesta != 1) {
                MessageBox.Show("Ocurrio un error al crear el cliente, intente de nuevo!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cliente creado correctamente!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private bool isValido() {
            bool isValido = true;

            if (string.IsNullOrEmpty(txtRazon.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRfc.Text)
                || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCurp.Text) || string.IsNullOrEmpty(txtDireccion.Text))
                isValido = false;

            return isValido;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
