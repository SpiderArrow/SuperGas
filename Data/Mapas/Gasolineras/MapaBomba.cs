using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Gasolineras
{
    public class MapaBomba
    {
        public int Id { get; set; }
        public int TipoCombustibleId { get; set; }
        public string Nombre { get; set; }
        public string TipoCombustible { get; set; }

        public decimal Galones { get; set; }
        public decimal Actuales { get; set; }
        public decimal Despachados { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
    }
}
