using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Mapas.Despachos;
using Data.Mapas.Reportes;

namespace Data.Models.Despachos
{
    public class DespachosVehiculos
    {
        [Key]
        public int Id { get; set; }
        public long EmpleadoId { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int TipoCombustibleId { get; set; }
        public long VehiculoId { get; set; }
        public int CisternaId { get; set; }
        public decimal GalonesDespachados { get; set; }
        public decimal PrecioGalon { get; set; }
        public string Observaciones { get; set; }
        public string UsuarioIngreso { get; set; }
        public List<MapaDespachosVehiculos> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from d in ctx.DespachosVehiculos
                                 join tc in ctx.TiposCombustibles on d.TipoCombustibleId equals tc.Id
                                 join c in ctx.Cisternas on d.CisternaId equals c.Id
                                 join g in ctx.Gasolineras on c.GasolineraId equals g.Id
                                 join v in ctx.Vehiculos on d.VehiculoId equals v.Id

                                 select new MapaDespachosVehiculos
                                 {
                                     Id = d.Id,
                                     FechaDespacho = d.FechaDespacho,
                                     CisternaId = g.Id,
                                     CamionId = c.Id,
                                     TipoCombustibleId = tc.Id,
                                     Gasolinera = g.Nombre,
                                     Cisterna = c.Descripcion,
                                     Camion = v.Nombre,
                                     TipoCombustible = tc.Descripcion,
                                     GalonesDespachados = d.GalonesDespachados,
                                     Observaciones = d.Observaciones
                                 }).ToList();

                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaDespachosVehiculos>();
                }
            }
            catch
            {
                return new List<MapaDespachosVehiculos>();
            }
        }


        public List<MapaIngresos> ListadoIngresos()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from d in ctx.DespachosVehiculos
                                 join tc in ctx.TiposCombustibles on d.TipoCombustibleId equals tc.Id
                                 join c in ctx.Cisternas on d.CisternaId equals c.Id
                                 join g in ctx.Gasolineras on c.GasolineraId equals g.Id
                                 join v in ctx.Vehiculos on d.VehiculoId equals v.Id
                                 join f in ctx.Facturas on d.Id equals f.DespachosVehiculoId
                                 join e in ctx.Empleados on d.EmpleadoId equals e.Id
                                 join df in ctx.DetalleFacturas on f.Id equals df.FacturaId

                                 select new MapaIngresos
                                 {
                                     FechaVenta = d.FechaDespacho,
                                     TipoCombustible = tc.Descripcion,
                                     Encargado = e.Nombres +" "+e.Apellidos,
                                     Vehiculo = v.Nombre,
                                     Cliente = g.Nombre,
                                     GalonesDespachados = d.GalonesDespachados,
                                     Costo = df.Costo,
                                     Precio = df.Precio,
                                     Utilidad = df.Precio - df.Costo,
                                 }).ToList();

                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaIngresos>();
                }
            }
            catch
            {
                return new List<MapaIngresos>();
            }
        }


        public DespachosVehiculos GetDespacho(int Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.DespachosVehiculos.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(DespachosVehiculos despacho)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(despacho).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(DespachosVehiculos despacho)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(despacho).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public int LastIdDespacho()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var despachos = ctx.DespachosVehiculos.ToList();
                    if (despachos.Any())
                    {
                        despachos = despachos.OrderByDescending(x => x.Id).ToList();
                        return despachos.FirstOrDefault().Id;
                    }
                    else
                        return 0;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
