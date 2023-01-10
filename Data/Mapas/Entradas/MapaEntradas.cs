using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Entradas
{
    public class MapaEntradas
    {
        public int Id { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int TipoCombustibleId { get; set; }
        public int BombaId { get; set; }
        public string Bomba { get; set; }
        public string TipoCombustible { get; set; }
        public decimal GalonesDisponiblesBomba { get; set; }
        public decimal GalonesEntrada { get; set; }
    }
}
