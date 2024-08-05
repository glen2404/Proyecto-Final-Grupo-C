using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaVisual
{
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            // Limpiar todos los campos de texto
            txtCedula.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la cédula del usuario desde la fila seleccionada
            var filaSeleccionada = dataGridView1.SelectedRows[0];
            string cedula = filaSeleccionada.Cells["Cedula"].Value.ToString();

            // Confirmar con el usuario si realmente desea eliminar el registro
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar el usuario con cédula " + cedula + "?",
                                                 "Confirmación de Eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Crear una instancia de ManageUsuario
                ManageUsuario manageUsuario = new ManageUsuario();

                try
                {
                    // Llamar al método para eliminar el usuario por cédula
                    manageUsuario.EliminarUsuarioPorCedula(cedula);

                    // Eliminar la fila seleccionada del DataGridView
                    dataGridView1.Rows.Remove(filaSeleccionada);

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error en caso de excepción
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}



