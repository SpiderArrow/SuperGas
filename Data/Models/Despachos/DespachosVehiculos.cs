using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Mapas.Despachos;

namespace Data.Models.Despachos
{
    public class DespachosVehiculos
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int TipoCombustibleId { get; set; }
        public long VehiculoId { get; set; }
        public long GasolineraId { get; set; }
        public decimal GalonesDespachados { get; set; }
        public decimal PrecioGalon { get; set; }
        public string Observaciones { get; set; }

        public List<MapaDespachosVehiculos> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from d in ctx.DespachosVehiculos
                                 join tc in ctx.TiposCombustibles on d.TipoCombustibleId equals tc.Id
                                 join g in ctx.Gasolineras on d.GasolineraId equals g.Id
                                 join c in ctx.Vehiculos on d.VehiculoId equals c.Id

                                 select new MapaDespachosVehiculos
                                 {
                                     Id = d.Id,
                                     GasolineraId = g.Id,
                                     CamionId = c.Id,
                                     TipoCombustibleId = tc.Id,
                                     Gasolinera = g.Nombre,
                                     Camion = c.Nombre,
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
    }
}
