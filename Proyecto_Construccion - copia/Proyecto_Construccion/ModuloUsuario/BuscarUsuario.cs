using CapaDatos;
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

namespace CapaVisual
{
    public partial class BuscarUsuario : Form
    {
        public BuscarUsuario()
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
    }
}
