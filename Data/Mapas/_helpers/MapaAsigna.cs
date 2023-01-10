using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas._helpers
{
    public class MapaAsigna
    {
        public int Id { get; set; }
        public long Entity1Id { get; set; }
        public int Entity2Id { get; set; }
        public string Entity1 { get; set; }
        public string Entity2 { get; set; }
        public string Estado { get; set; }
    }
}
