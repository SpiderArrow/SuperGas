
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
    public class AsignacionZonas
    {
        [Key]
        public int Id { get; set; }
        public int RutaId { get; set; }
        public int ZonaId { get; set; }

        public List<MapaAsigna> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from a in ctx.AsignacionZonas
                                 join z in ctx.Zonas on a.ZonaId equals z.Id
                                 join r in ctx.Rutas on a.RutaId equals r.Id

                                 select new MapaAsigna
                                 {
                                     Id = a.Id,
                                     Entity1Id = z.Id,
                                     Entity2Id = r.Id,
                                     Entity1 = z.Descripcion,                                     
                                     Entity2 = r.CodigoRuta,                                    
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


        public AsignacionZonas GetRuta(int Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.AsignacionZonas.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(AsignacionZonas rt)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(rt).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(AsignacionZonas rt)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(rt).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(AsignacionZonas rt)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(rt).State = EntityState.Deleted;
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
