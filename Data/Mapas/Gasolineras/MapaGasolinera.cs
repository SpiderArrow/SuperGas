using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Gasolineras
{
    public class MapaGasolinera
    {
        public long Id { get; set; }
        public int ZonaId { get; set; }
        public int MunicipioId { get; set; }
        public int DeptoId { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
       
        public string Correo { get; set; }
        public string Telefonos1 { get; set; }
        public string Telefonos2 { get; set; }
        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Nit { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
