using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ManageInventario
    {
        private Connection connection = new Connection();

        public ManageInventario()
        {
            connection = new Connection();
        }

        // Método para insertar un zapato
        public void InsertarZapato(int id, string modelo, string marca, string color, int talla, decimal precio, int cantidad)
        {
            using (SqlCommand cmd = new SqlCommand("sp_InsertarZapato", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Modelo", modelo);
                cmd.Parameters.AddWithValue("@Marca", marca);
                cmd.Parameters.AddWithValue("@Color", color);
                cmd.Parameters.AddWithValue("@Talla", talla);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);

                try
                {
                    connection.Abrir();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Zapato insertado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar el zapato: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
        }

        // Método para actualizar un zapato
        public void ActualizarZapato(int id, string modelo, string marca, string color, int talla, decimal precio, int cantidad)
        {
            using (SqlCommand cmd = new SqlCommand("sp_ActualizarZapato", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Modelo", modelo);
                cmd.Parameters.AddWithValue("@Marca", marca);
                cmd.Parameters.AddWithValue("@Color", color);
                cmd.Parameters.AddWithValue("@Talla", talla);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);

                try
                {
                    connection.Abrir();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Zapato actualizado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar el zapato: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
        }

        // Método para eliminar un zapato
        public void EliminarZapato(int id)
        {
            using (SqlCommand cmd = new SqlCommand("sp_EliminarZapato", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Abrir();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Zapato eliminado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el zapato: " + ex.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
        }

        // Método para obtener un zapato por ID
        public DataTable ObtenerZapatoPorId(int id)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerZapatoPorId", connection.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

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
                    Console.WriteLine("Error al obtener el zapato: " + ex.Message);
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