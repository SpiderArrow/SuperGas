using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Gasolineras
{
    public class MapaPista
    {
        public int Id { get; set; }
        public long GasolineraId { get; set; }
        public string Descripcion { get; set; }
        public string Gasolinera { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
    }
}
