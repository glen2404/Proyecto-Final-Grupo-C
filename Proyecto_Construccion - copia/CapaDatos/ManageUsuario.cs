using CapaDatos.Interface;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using System.Data;
namespace CapaDatos
{
    public class ManageUsuario
    {
        private Connection connection = new Connection();

        public ManageUsuario()
        {
            connection = new Connection();
        }

        public void InsertarUsuario(string cedula, string nombre, string apellido, string telefono, string email, string nombreUsuario, string contrasenia, string rol)
        {
            using (SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);
                cmd.Parameters.AddWithValue("@Rol", rol);

                try
                {
                    connection.Abrir();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Usuario insertado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar el usuario: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
        }

        public void ActualizarUsuario(string cedula, string nombre, string apellido, string telefono, string email, string nombreUsuario, string contrasenia, string rol)
        {
            using (SqlCommand cmd = new SqlCommand("sp_ActualizarUsuario", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                
                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);
                cmd.Parameters.AddWithValue("@Rol", rol);

                try
                {
                    connection.Abrir();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar el usuario: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
        }

        public DataTable ObtenerUsuarioPorCedula(string cedula)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerUsuario", connection.connect))
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
                    Console.WriteLine("Usuario obtenido exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el usuario: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
            return dt;
        }

        public void EliminarUsuarioPorCedula(string cedula)
        {
            using (SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula", cedula);

                try
                {
                    connection.Abrir();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Usuario eliminado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el usuario: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
        }
    }
}