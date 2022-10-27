using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Direcciones
{
    public class MapaRutas
    {
        public int Id { get; set; }
        public int ZonaId { get; set; }
        public string Zona { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
    }
}
