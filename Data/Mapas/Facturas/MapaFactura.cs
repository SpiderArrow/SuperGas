using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Facturas
{
    public class MapaFactura
    {
        public long Id { get; set; }
        public string FechaVenta { get; set; }
        public string Vendedor { get; set; }
        public string NoFactura { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string NIT { get; set; }
        public string Movimiento { get; set; }
        public decimal TotalFactura { get; set; }
    }
}
