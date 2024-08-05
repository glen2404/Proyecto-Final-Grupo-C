using Proyecto_Construccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using System.Security.Cryptography.X509Certificates;

namespace CapaVisual
{
    public partial class RegistrarUsuario : Form
    {
        private ManageUsuario manageUsuario = new ManageUsuario();
        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNombreUsuario.Clear();
            txtContrasenia.Clear();
            cb1.SelectedIndex = 0; // Selecciona el primer rol por defecto
        }
        public RegistrarUsuario()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txtCedula.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                string nombreUsuario = txtNombreUsuario.Text;
                string contrasenia = txtContrasenia.Text;
                string rol = cb1.SelectedItem.ToString();

                // Insertar el usuario en la base de datos usando ManageUsuario
                manageUsuario.InsertarUsuario(cedula, nombre, apellido, telefono, email, nombreUsuario, contrasenia, rol);

                // Mostrar mensaje de éxito y limpiar los campos
                MessageBox.Show("Usuario registrado exitosamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }

        }
    }
}
