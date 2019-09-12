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
    public partial class FrmFormCliente : Form
    {
        private bool isNuevo;

        public FrmFormCliente(bool isNuevo)
        {
            InitializeComponent();
            this.isNuevo = isNuevo;
            
        }

        private void FrmFormCliente_Load(object sender, EventArgs e)
        {
            lblAccion.Text = (isNuevo) ? "Nuevo" : "Editar";
        }
    }
}
