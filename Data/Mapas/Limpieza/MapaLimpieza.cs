using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Limpieza
{
    public class MapaLimpieza
    {

        public long Id { get; set; }
        public long? GasolineraId { get; set; }
        public long? VehiculoId { get; set; }
        public int? BombasId { get; set; }
        public int? PistasId { get; set; }
        public int EstadoLimpiezaId { get; set; }
        public long EncargadoId { get; set; }

        public string Encargado { get; set; }
        public string Gasolinera { get; set; }
        public string Camion { get; set; }
        public string Bomba { get; set; }
        public string Pista { get; set; }
        public string Estado { get; set; }

        public string HoraInicio { get; set; }
        public string HoraFinal { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaLimpieza { get; set; }
        public DateTime ProximaLimpieza { get; set; }

    }
}
