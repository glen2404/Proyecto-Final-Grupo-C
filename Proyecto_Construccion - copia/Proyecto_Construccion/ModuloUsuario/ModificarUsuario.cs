using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos.Interface;
using CapaDatos;

namespace CapaVisual
{
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            // Limpiar todos los campos de texto
            txtCedula.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox8.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            // Limpiar el ComboBox
            comboBox1.SelectedIndex = -1;
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {

        }
        private void CargarDatosEnDataGridView()
        {
            string query = "SELECT * FROM Usuario"; // Consulta SQL para obtener datos

            // Crear un objeto DataTable para almacenar los datos
            DataTable dt = new DataTable();

            // Crear y abrir una conexión
            using (SqlConnection conn = new SqlConnection(Connection.cadena))
            {
                try
                {
                    conn.Open(); // Abrir la conexión

                    // Crear un SqlDataAdapter para ejecutar la consulta y llenar el DataTable
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.Fill(dt); // Llenar el DataTable con los resultados de la consulta
                    }

                    // Asignar el DataTable al DataGridView
                    dataGridView1.DataSource = dt;

                    // Mensaje opcional para confirmar que los datos fueron cargados
                    Console.WriteLine("Datos cargados en DataGridView.");
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje de error en consola
                    Console.WriteLine("Error al cargar los datos: " + ex.Message);
                }
                finally
                {
                    conn.Close(); // Cerrar la conexión
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener la cédula del TextBox
            string cedula = txtCedula.Text;

            // Crear una instancia de ManageUsuario
            ManageUsuario manageUsuario = new ManageUsuario();

            // Obtener el usuario por cédula
            DataTable dt = manageUsuario.ObtenerUsuarioPorCedula(cedula);

            // Verificar si se encontraron resultados
            if (dt.Rows.Count > 0)
            {
                // Mostrar los resultados en el DataGridView
                dataGridView1.DataSource = dt;
            }
            else
            {
                // Mostrar mensaje si no se encontraron resultados
                MessageBox.Show("No se encontró ningún usuario con la cédula proporcionada.", "Resultado de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el DataGridView si no se encontraron resultados
                dataGridView1.DataSource = null;
            }
            LimpiarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Obtener los valores de las celdas
                string cedula = filaSeleccionada.Cells["Cedula"].Value.ToString();
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string nombreUsuario = filaSeleccionada.Cells["NombreUsuario"].Value.ToString();
                string contrasenia = filaSeleccionada.Cells["Contrasenia"].Value.ToString(); // Asegúrate de que la columna "Contrasenia" existe en el DataGridView
                string rol = filaSeleccionada.Cells["Rol"].Value.ToString();


                // Asignar los valores a los controles
                textBox2.Text = cedula;
                textBox3.Text = nombre;
                textBox4.Text = apellido;
                textBox8.Text = telefono;
                textBox5.Text = email;
                // Asegúrate de que tienes un TextBox para la contraseña
                textBox6.Text = nombreUsuario;
                textBox7.Text = contrasenia;


                // Asumimos que el rol está en un ComboBox
                if (comboBox1.Items.Contains(rol))
                {
                    comboBox1.SelectedItem = rol;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila en el DataGridView.", "Selección de Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cedulatmp = textBox2.Text;
            string nombretmp = textBox3.Text;
            string apellidotmp = textBox4.Text;
            string telefonotmp = textBox8.Text;
            string emailtmp = textBox5.Text;
            string nombreUsuariotmp = textBox6.Text;
            string contraseniatmp = textBox7.Text;
            string roltmp = comboBox1.SelectedItem.ToString();
            // Obtener los datos de los controles
            string cedula = cedulatmp;
            string nombre = nombretmp;
            string apellido = apellidotmp;
            string telefono = telefonotmp;
            string email = emailtmp;
            string nombreUsuario = nombreUsuariotmp;
            string contrasenia = contraseniatmp; // Obtener la contraseña del TextBox
            string rol = roltmp;


            // Crear una instancia de ManageUsuario
            ManageUsuario manageUsuario = new ManageUsuario();

            // Llamar al método para actualizar el usuario
            manageUsuario.ActualizarUsuario(cedula, nombre, apellido, telefono, email, nombreUsuario, contrasenia, rol);

            // Mostrar mensaje de éxito
            MessageBox.Show("Datos actualizados correctamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Opcional: Actualizar el DataGridView después de guardar los cambios
            DataTable dt = manageUsuario.ObtenerUsuarioPorCedula(cedula);
            dataGridView1.DataSource = dt;

            // Limpiar los campos de texto y el comboBox
            LimpiarCampos();
        }
    }
}
