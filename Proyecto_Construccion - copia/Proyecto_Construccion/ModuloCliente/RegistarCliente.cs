using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaVisual
{
    public partial class RegistrarCliente : Form
    {
        private ManageCliente manageCliente = new ManageCliente();
        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
        public RegistrarCliente()
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
                string direccion = txtDireccion.Text;
                DateTime fechaRegistro = dateTimePicker1.Value.Date;

                // Insertar el cliente en la base de datos usando ManageCliente
                manageCliente.InsertarCliente(cedula, nombre, apellido, telefono, email, direccion, fechaRegistro);

                // Mostrar mensaje de éxito y limpiar los campos
                MessageBox.Show("Cliente registrado exitosamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message);
            }
        }
    }
}
