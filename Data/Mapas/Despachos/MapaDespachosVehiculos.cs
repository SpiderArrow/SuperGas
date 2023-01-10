using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Despachos
{
    public class MapaDespachosVehiculos
    {
        public int Id { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int TipoCombustibleId { get; set; }
        public long CamionId { get; set; }
        public long CisternaId { get; set; }

        public string TipoCombustible { get; set; }
        public string Camion { get; set; }
        public string Gasolinera { get; set; }        
        public string Cisterna { get; set; }        

        public decimal GalonesDespachados { get; set; }
        public string Observaciones { get; set; }
    }
}
