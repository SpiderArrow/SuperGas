using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas._helpers

{
    public class MapaEntity
    {
        public int Id { get; set; }
        public int PadreId { get; set; }
        public string Padre { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
