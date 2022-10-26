using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Vehiculos
{
    public class MapaVehiculos
    {
        public long Id { get; set; }
        public int TipoCombustibleId { get; set; }
        public int MarcaId { get; set; }
        public long EmpleadoId { get; set; }

        public string Marca { get; set; }
        public string TipoCombustible { get; set; }
        public string Encargado { get; set; }
        
        public int Kilometraje { get; set; }
        public string Nombre { get; set; }
        public string Placa { get; set; }
        public string Codigo { get; set; }
        public string Modelo { get; set; }
        public string NumeroMotor { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public decimal CantidadGalones { get; set; }
        public decimal GalonesActuales { get; set; }
        public decimal GalonesDespachados { get; set; }
    }
}
