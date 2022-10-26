using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Gasolineras
{
    public class MapaPrecioGalon
    {
        public int Id { get; set; }
        public int TipoCombustibleId { get; set; }
        public string TipoCombustible { get; set; }

        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public decimal Utilidad { get; set; }
        public DateTime FechaPrecio { get; set; }
    }
}
