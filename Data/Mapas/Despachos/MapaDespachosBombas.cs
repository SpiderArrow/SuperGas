using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Despachos
{
    public class MapaDespachosBombas
    {
        public int Id { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int TipoCombustibleId { get; set; }
        public int BombaId { get; set; }
        public long CamionId { get; set; }

        public string TipoCombustible { get; set; }
        public string Bomba { get; set; }
        public string Camion { get; set; }

        public decimal GalonesDespachados { get; set; }
        public string Observaciones { get; set; }
    }
}
