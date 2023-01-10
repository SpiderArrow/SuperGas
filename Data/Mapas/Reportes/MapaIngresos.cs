using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Reportes
{
    public class MapaIngresos
    {
        public DateTime FechaVenta { get; set; }        
        public string TipoCombustible { get; set; }        
        public string Encargado { get; set; }
        public string Vehiculo { get; set; }
        public string Cliente { get; set; }
        public decimal GalonesDespachados { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Utilidad { get; set; }
    }
}
