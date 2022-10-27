


using Data.Models.Usuarios;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Linq;
using System;
using Data.Models.Direcciones;
using Data.Models.Gasolineras;
using Data.Models.Vehiculos;
using Data.Mapas;
using Data.Models.Empleados;
using Data.Models.Limpieza;
using Data.Models.Despachos;
using Data.Models.Facturas;
using Data.Models.Asignacion;

namespace Data.Models
{
    public class ModelContext : IdentityDbContext<User>
    {
        public ModelContext() : base("SuperGas")
        {

        }

        //DIRECCIONES
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Municipios> Municipios { get; set; }
        public DbSet<Zonas> Zonas { get; set; }
        public DbSet<Rutas> Rutas { get; set; }

        //GASOLINERAS
        public DbSet<Gasolinera> Gasolineras { get; set; }
        public DbSet<Bombas> Bombas { get; set; }
        public DbSet<Pistas> Pistas { get; set; }
        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<Cisternas> Cisternas { get; set; }
        public DbSet<PrecioGalon> PrecioGalon { get; set; }

        //VEHICULOS
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<TipoCombustible> TiposCombustibles { get; set; }

        //EMPLEADOS
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<RolEmpleado> RolEmpleados { get; set; }

        //LIMPIEZA
        public DbSet<HistorialLimpieza> HistorialLimpiezas { get; set; }
        public DbSet<EstadoLimpieza> EstadoLimpiezas { get; set; }

        //DESPACHOS
        public DbSet<DespachosBombas> DespachosBombas { get; set; }
        public DbSet<DespachosVehiculos> DespachosVehiculos { get; set; }

        //FACTURACION
        public DbSet<TipoMovimiento> TipoMovimientos { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Factura> Facturas{ get; set; }


        //ASIGNACIONES
        public DbSet<AsignacionRuta> AsignacionRutas { get; set; }
        public DbSet<AsignacionZonas> AsignacionZonas { get; set; }


    }

}