using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Facturas
{
    public class MapaDetalleFactura
    {
        public long Id { get; set; }
        public long FacturaId { get; set; }
        public int DespachoVehiculoId { get; set; }
        public string Vehiculo { get; set; }
        public string Cisterna { get; set; }
        public string Gasolinera { get; set; }
        public decimal CantidadGalones { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }

    }
}
