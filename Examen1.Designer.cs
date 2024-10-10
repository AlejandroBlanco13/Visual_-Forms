using System;
using System.Windows.Forms;

namespace Examen
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCanton;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;

        private void InitializeComponent()
        {
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblCanton = new System.Windows.Forms.Label();
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.Location = new System.Drawing.Point(10, 20);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(100, 23);
            this.lblIdentificacion.TabIndex = 0;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(120, 20);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(152, 20);
            this.txtIdentificacion.TabIndex = 1;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.a);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(10, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.Location = new System.Drawing.Point(10, 100);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(100, 23);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(120, 100);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(65, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(10, 140);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 23);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 140);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(10, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Location = new System.Drawing.Point(10, 220);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(100, 23);
            this.lblProvincia.TabIndex = 10;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(120, 220);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(200, 20);
            this.txtProvincia.TabIndex = 11;
            // 
            // lblCanton
            // 
            this.lblCanton.Location = new System.Drawing.Point(10, 260);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(100, 23);
            this.lblCanton.TabIndex = 12;
            this.lblCanton.Text = "Cantón:";
            // 
            // txtCanton
            // 
            this.txtCanton.Location = new System.Drawing.Point(120, 260);
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(200, 20);
            this.txtCanton.TabIndex = 13;
            // 
            // lblDistrito
            // 
            this.lblDistrito.Location = new System.Drawing.Point(10, 300);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(100, 23);
            this.lblDistrito.TabIndex = 14;
            this.lblDistrito.Text = "Distrito:";
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(120, 300);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(200, 20);
            this.txtDistrito.TabIndex = 15;
            // 
            // lblBarrio
            // 
            this.lblBarrio.Location = new System.Drawing.Point(10, 340);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(100, 23);
            this.lblBarrio.TabIndex = 16;
            this.lblBarrio.Text = "Barrio:";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(120, 340);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(200, 20);
            this.txtBarrio.TabIndex = 17;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(50, 380);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(150, 380);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(250, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.lblCanton);
            this.Controls.Add(this.txtCanton);
            this.Controls.Add(this.lblDistrito);
            this.Controls.Add(this.txtDistrito);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Formulario de Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
