namespace AdministrarClientes
{
    partial class FrmFormContacto
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
            this.btnGurdar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGurdar
            // 
            this.btnGurdar.Location = new System.Drawing.Point(450, 310);
            this.btnGurdar.Name = "btnGurdar";
            this.btnGurdar.Size = new System.Drawing.Size(75, 23);
            this.btnGurdar.TabIndex = 8;
            this.btnGurdar.Text = "&Guardar";
            this.btnGurdar.UseVisualStyleBackColor = true;
            this.btnGurdar.Click += new System.EventHandler(this.btnGurdar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "** Campos obligatorios";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(44, 265);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(447, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Dirección  **";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(291, 201);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Correo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(291, 136);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Teléfono  **";
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(291, 81);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(200, 20);
            this.txtAPaterno.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Apellido Paterno  **";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(44, 201);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(200, 20);
            this.txtPuesto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Puesto  **";
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(44, 136);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(200, 20);
            this.txtAMaterno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellido Materno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(44, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre  **";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(35, 15);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(23, 31);
            this.lblAccion.TabIndex = 17;
            this.lblAccion.Text = ".";
            // 
            // FrmFormContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 385);
            this.Controls.Add(this.btnGurdar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFormContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:. Formulario contacto .:.";
            this.Load += new System.EventHandler(this.FrmFormContacto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGurdar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccion;
    }
}