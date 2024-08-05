using CapaDatos.Interface;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ManageCliente
    {
        private Connection connection = new Connection();

        public ManageCliente()
        {
            connection = new Connection();
        }

        // Método para insertar un cliente
        public void InsertarCliente(string cedula, string nombre, string apellido, string telefono, string email, string direccion, DateTime fechaRegistro)
        {
            using (SqlCommand cmd = new SqlCommand("sp_InsertarCliente", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);

                try
                {
                    connection.Abrir();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Cliente insertado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar el cliente: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
        }

        // Método para actualizar un cliente
        public void ActualizarCliente(string cedula, string nombre, string apellido, string telefono, string email, string direccion, DateTime fechaRegistro)
        {
            using (SqlCommand cmd = new SqlCommand("sp_ActualizarCliente", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);

                try
                {
                    connection.Abrir();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Cliente actualizado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
        }

        // Método para eliminar un cliente
        public void EliminarCliente(string cedula)
        {
            using (SqlCommand cmd = new SqlCommand("sp_EliminarCliente", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula", cedula);

                try
                {
                    connection.Abrir();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Cliente eliminado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el cliente: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
        }

        // Método para obtener un cliente por cédula
        public DataTable ObtenerCliente(string cedula)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerCliente", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula", cedula);

                try
                {
                    connection.Abrir();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el cliente: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
            return dt;
        }
    }
}
