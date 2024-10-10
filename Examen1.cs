using System;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Limpiar los campos
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtProvincia.Clear();
            txtCanton.Clear();
            txtDistrito.Clear();
            txtBarrio.Clear();

            // Ubicar el cursor en la caja de texto de identificación
            txtIdentificacion.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios tengan datos
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                MessageBox.Show("El campo de identificación es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentificacion.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo de nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("El campo de edad es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                return;
            }

            // Puedes agregar más validaciones según sea necesario

            // Lógica para agregar datos
            MessageBox.Show("Datos agregados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación al salir
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // Manejar el evento de cierre del formulario
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Cancel)
            {
                e.Cancel = true; // Cancelar el cierre del formulario
            }
        }

        private void lblBarrio_Click(object sender, EventArgs e)
        {

        }

        private void a(object sender, EventArgs e)
        {

        }
    }
}
