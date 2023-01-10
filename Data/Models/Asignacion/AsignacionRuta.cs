using Data.Mapas._helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Asignacion
{
    public class AsignacionRuta
    {
        [Key]
        public int Id { get; set; }
        public long VehiculoId { get; set; }
        public int RutaId { get; set; }

        public List<MapaAsigna> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from a in ctx.AsignacionRutas
                                 join v in ctx.Vehiculos on a.VehiculoId equals v.Id
                                 join r in ctx.Rutas on a.RutaId equals r.Id

                                select new MapaAsigna
                                {
                                    Id = a.Id,                                  
                                    Entity1Id = v.Id,                                    
                                    Entity2Id = r.Id,
                                    Entity1 = v.Nombre,
                                    Entity2 = r.CodigoRuta
                                }).ToList();

                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaAsigna>();
                }
            }
            catch
            {
                return new List<MapaAsigna>();
            }
        }

        public string Insert(AsignacionRuta ar)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(ar).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(AsignacionRuta ar)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(ar).State = EntityState.Added;
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
