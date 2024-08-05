using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVentas { get; set; }
        public virtual Factura Factura { get; set; }

        public Venta()
        {
            DetalleVentas = new HashSet<DetalleVenta>();
        }

        public void AgregarDetalleVenta(DetalleVenta detalleVenta)
        {
            DetalleVentas.Add(detalleVenta);
            Total += detalleVenta.Precio * detalleVenta.Cantidad;
        }
    }

    public class DetalleVenta
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public virtual Venta Venta { get; set; }
        public int ZapatoId { get; set; }
        public virtual Zapato Zapato { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}