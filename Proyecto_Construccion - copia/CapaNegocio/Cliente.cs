using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente : Persona
    {
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Cliente(string cedula, string nombre, string apellido, string telefono, string email, string direccion, DateTime fechaRegistro)
            : base(cedula, nombre, apellido, telefono, email)
        {
            Direccion = direccion;
            FechaRegistro = fechaRegistro;
        }
    }
}
