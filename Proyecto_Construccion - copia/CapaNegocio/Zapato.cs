using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Zapato
    {
        public int Id { get; set; }
        public string Modelo {  get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public int Talla { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public Zapato(int id, string modelo, string marca, string color, int talla, decimal  precio, int cantidad)
        { 
            Id = id;
            Modelo = modelo;
            Marca = marca;
            Color = color;
            Talla = talla;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
