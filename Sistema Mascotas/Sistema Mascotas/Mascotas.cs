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
    public partial class Mascotas : Form
    {
        private List<Mascota> mascotas;
        private List<Dueño> dueños;

        public Mascotas(List<Dueño> dueños)
        {
            InitializeComponent();
            mascotas = new List<Mascota>();
            this.dueños = dueños;
            CargarDueños();
        }

        private void CargarDueños()
        {
            cmbDueño.Items.Clear();
            foreach (Dueño dueño in dueños)
            {
                cmbDueño.Items.Add(dueño);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);
                string raza = txtRaza.Text;
                Dueño dueño = cmbDueño.SelectedItem as Dueño;

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(raza) || dueño == null)
                {
                    throw new Exception("Todos los campos son obligatorios.");
                }

                Mascota nuevaMascota = new Mascota(nombre, edad, raza, dueño);
                mascotas.Add(nuevaMascota);

                LimpiarCampos();
                MostrarMascotas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarMascotas()
        {
            dataGridViewMascotas.Rows.Clear();

            foreach (Mascota mascota in mascotas)
            {
                dataGridViewMascotas.Rows.Add(mascota.Nombre, mascota.Edad, mascota.Raza, mascota.Dueño.Nombre);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtRaza.Text = "";
            cmbDueño.SelectedIndex = -1;
        }
        private void Marcotas_Load(object sender, EventArgs e)
        {

        }


        private void btn_duenos_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Crear una instancia del formulario DueñosForm
            DuenosForm duenosForm = new DuenosForm();
            
            // Pasar la lista de mascotas al formulario DuenosForm
            duenosForm.ObtenerDueños(mascotas);

            // Mostrar el formulario DueñosForm
            duenosForm.Show();
        }
    }
}
