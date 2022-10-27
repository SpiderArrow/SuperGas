using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Mapas._helpers;
using Data.Mapas.Gasolineras;

namespace Data.Models.Gasolineras
{
    public  class Cisternas
    {
        [Key]
        public int Id { get; set; }
        public int TipoCombustibleId { get; set; }
        public long GasolineraId { get; set; }
        public string Descripcion { get; set; }
        public decimal CantidadGalones { get; set; }
        public decimal GalonesActuales { get; set; }
        public decimal GalonesDespachados { get; set; }
        public string Observaciones { get; set; }
        public bool IsActive { get; set; }

        public List<MapaCisterna> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from c in ctx.Cisternas
                                 join tc in ctx.TiposCombustibles on c.TipoCombustibleId equals tc.Id
                                 join g in ctx.Gasolineras on c.GasolineraId equals g.Id

                                 select new MapaCisterna
                                 {
                                     Id = c.Id,
                                     TipoCombustibleId = tc.Id,
                                     TipoCombustible = tc.Descripcion,
                                     GasolineraId = g.Id,
                                     Gasolinera = tc.Descripcion,
                                     Nombre = c.Descripcion,
                                     Galones = c.CantidadGalones,
                                     Actuales = c.GalonesActuales,
                                     Despachados = c.GalonesDespachados,
                                     Estado = g.IsActive ? "Activo" : "Desactivado",
                                 }).ToList();

                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaCisterna>();
                }
            }
            catch
            {
                return new List<MapaCisterna>();
            }
        }

        public List<MapaSimple> ListadoDespacho()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from c in ctx.Cisternas
                                 where c.IsActive == true
                                 select new MapaSimple
                                 {
                                     Id = c.Id,
                                     Descripcion = c.Descripcion
                                 }).ToList();

                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaSimple>();
                }
            }
            catch
            {
                return new List<MapaSimple>();
            }
        }

        public List<MapaEntity> Listado(int? GasoId)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from c in ctx.Cisternas
                                 join g in ctx.Gasolineras on c.GasolineraId equals g.Id
                                 where c.IsActive == true
                                 select new MapaEntity
                                 {
                                     Id = c.Id,
                                     PadreId = (int)g.Id,
                                     Descripcion = c.Descripcion
                                 }).ToList();

                    if (lista.Any())
                        if (GasoId != null)
                            return lista.Where(x => x.PadreId == Convert.ToInt32(GasoId)).ToList();
                        else
                            return lista;
                    else
                        return new List<MapaEntity>();
                }
            }
            catch
            {
                return new List<MapaEntity>();
            }
        }


        public Cisternas GetCisterna(int Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Cisternas.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(Cisternas cs)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(cs).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(Cisternas cs)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(cs).State = EntityState.Modified;
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
