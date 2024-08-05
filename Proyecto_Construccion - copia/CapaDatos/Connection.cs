using System.Data.SqlClient;
using System;
namespace CapaDatos.Interface
{
    public class Connection
    {
        public static string cadena = "Data Source=LAPTOP-ULONAV60\\SQLEXPRESS;Initial Catalog=ProyectoConstruccion;Integrated Security=True;TrustServerCertificate=True";
        public SqlConnection connect = new SqlConnection();

        public Connection()
        {
            connect.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                connect.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la base de datos: " + ex.Message);
            }
        }

        public void Cerrar()
        {
            try
            {
                connect.Close();
                Console.WriteLine("Conexion Cerrada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la base de datos: " + ex.Message);
            }
        }
    }
}
