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
using Bl;

namespace AdministrarClientes
{
    public partial class FrmFormContacto : Form
    {
        private clContactoEntity contacto = new clContactoEntity();
        private readonly clContactoBl contactoBl = new clContactoBl();
        private bool isNuevo;
        private int idCliente;

        public FrmFormContacto(bool isNuevo, clContactoEntity contacto, int idCliente)
        {
            InitializeComponent();
            this.contacto = contacto;
            this.isNuevo = isNuevo;
            this.idCliente = idCliente;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmFormContacto_Load(object sender, EventArgs e)
        {
            lblAccion.Text = (isNuevo) ? "Nuevo" : "Editar";
            llenaFormulario();
        }

        private void llenaFormulario()
        {
            txtNombre.Text = contacto.nombre;
            txtAPaterno.Text = contacto.apellidoPaterno;
            txtAMaterno.Text = contacto.apellidoMaterno;
            txtTelefono.Text = contacto.telefono;
            txtPuesto.Text = contacto.puesto;
            txtCorreo.Text = contacto.correo;
            txtDireccion.Text = contacto.direccion;
        }

        private bool isValido()
        {
            bool isValido = true;

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtAPaterno.Text) 
                || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtPuesto.Text) || string.IsNullOrEmpty(txtDireccion.Text))
                isValido = false;

            return isValido;
        }

        private void btnGurdar_Click(object sender, EventArgs e)
        {
            if (!isValido())
            {
                MessageBox.Show("Los campos con ** son obligatorios!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (isNuevo)
            {
                gurdarContacto();
            }
            else
            {
                actualizarContacto();
            }
        }

        private void actualizarContacto()
        {
            contacto.nombre = txtNombre.Text;
            contacto.apellidoPaterno = txtAPaterno.Text;
            contacto.apellidoMaterno = txtAMaterno.Text;
            contacto.telefono = txtTelefono.Text;
            contacto.puesto = txtPuesto.Text;
            contacto.correo = txtCorreo.Text;
            contacto.direccion = txtDireccion.Text;

            int respuesta = contactoBl.editarContacto(contacto);

            if (respuesta != 1)
            {
                MessageBox.Show("Ocurrio un error al actualizar el contacto, intente de nuevo!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Contacto actualizado correctamente!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void gurdarContacto()
        {
            contacto.idCliente = idCliente;
            contacto.nombre = txtNombre.Text;
            contacto.apellidoPaterno = txtAPaterno.Text;
            contacto.apellidoMaterno = txtAMaterno.Text;
            contacto.telefono = txtTelefono.Text;
            contacto.puesto = txtPuesto.Text;
            contacto.correo = txtCorreo.Text;
            contacto.direccion = txtDireccion.Text;

            int respuesta = contactoBl.crearNuevoContacto(contacto);

            if(respuesta != 1)
            {
                MessageBox.Show("Ocurrio un error al crear el contacto, intente de nuevo!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Contacto creado correctamente!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
