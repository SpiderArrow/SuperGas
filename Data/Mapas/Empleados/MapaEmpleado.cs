using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Empleados
{
    public class MapaEmpleado
    {
        public long Id { get; set; }
        public int? RolEmpleadoId { get; set; }
        public int? ZonaId { get; set; }
        public int? DeptoId { get; set; }
        public int? MunicipioId { get; set; }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string CodigoEmpleado { get; set; }       
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Nit { get; set; }
        public string DPI { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }
        public int Edad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Estado { get; set; }
    }
}
