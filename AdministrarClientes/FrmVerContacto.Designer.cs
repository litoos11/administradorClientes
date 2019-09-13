namespace AdministrarClientes
{
    partial class FrmVerContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlInfoContacto = new System.Windows.Forms.Panel();
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlInfoContacto.SuspendLayout();
            this.grpContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfoContacto
            // 
            this.pnlInfoContacto.Controls.Add(this.grpContacto);
            this.pnlInfoContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoContacto.Location = new System.Drawing.Point(0, 0);
            this.pnlInfoContacto.Name = "pnlInfoContacto";
            this.pnlInfoContacto.Size = new System.Drawing.Size(804, 225);
            this.pnlInfoContacto.TabIndex = 0;
            // 
            // grpContacto
            // 
            this.grpContacto.Controls.Add(this.lblDireccion);
            this.grpContacto.Controls.Add(this.lblCorreo);
            this.grpContacto.Controls.Add(this.lblTelefono);
            this.grpContacto.Controls.Add(this.lblPuesto);
            this.grpContacto.Controls.Add(this.lblNombre);
            this.grpContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContacto.Location = new System.Drawing.Point(0, 0);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Size = new System.Drawing.Size(804, 225);
            this.grpContacto.TabIndex = 0;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Contacto";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(20, 169);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(74, 16);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(157, 82);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(63, 20);
            this.lblCorreo.TabIndex = 14;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(15, 82);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 20);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(19, 129);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(65, 20);
            this.lblPuesto.TabIndex = 12;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 25);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // FrmVerContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 225);
            this.Controls.Add(this.pnlInfoContacto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:. Ver Contacto .:.";
            this.Load += new System.EventHandler(this.FrmVerContacto_Load);
            this.pnlInfoContacto.ResumeLayout(false);
            this.grpContacto.ResumeLayout(false);
            this.grpContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfoContacto;
        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblNombre;
    }
}