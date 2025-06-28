using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Mascotas
{
    public partial class DuenosForm : Form
    {

        private List<Dueño> dueños;

        public DuenosForm()
        {
            InitializeComponent();
            dueños = new List<Dueño>();
        }

        public void ObtenerDueños(List<Mascota> mascotas)
        {
            foreach (Mascota mascota in mascotas)
            {
                Dueño dueño = mascota.Dueño;
                if (!dueños.Contains(dueño))
                {
                    dueños.Add(dueño);
                }
            }

            MostrarDueños();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(telefono))
                {
                    throw new Exception("Todos los campos son obligatorios.");
                }

                Dueño nuevoDueño = new Dueño(nombre, direccion, telefono);
                dueños.Add(nuevoDueño);

                LimpiarCampos();
                MostrarDueños();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarDueños()
        {
            dataGridViewDueños.Rows.Clear();

            foreach (Dueño dueño in dueños)
            {
                dataGridViewDueños.Rows.Add(dueño.Nombre, dueño.Direccion, dueño.Telefono);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void btn_Mascotas_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Crear una instancia del formulario DueñosForm
            Mascotas mascotasForm = new Mascotas(dueños);

            // Mostrar el formulario DueñosForm
            mascotasForm.Show();
        }
    }
}
