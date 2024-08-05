using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Factura
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public virtual Venta Venta { get; set; }
        public DateTime FechaEmision { get; set; }
        public string NumeroFactura { get; set; }
        public decimal Total { get; set; }

        public Factura(Venta venta)
        {
            VentaId = venta.Id;
            Venta = venta;
            Total = venta.Total;
        }
    }
}
