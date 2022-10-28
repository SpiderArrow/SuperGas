using Data.Mapas._helpers;
using Data.Mapas.Gasolineras;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Gasolineras
{
    public class Bombas
    {
        [Key]
        public int Id { get; set; }
        public int TipoCombustibleId { get; set; }
        public string Descripcion { get; set; }
        public decimal CantidadGalones { get; set; }
        public decimal GalonesActuales { get; set; }
        public decimal GalonesDespachados { get; set; }
        public string Observaciones { get; set; }
        public bool IsActive { get; set; }

        public List<MapaBomba> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from b in ctx.Bombas
                                 join tc in ctx.TiposCombustibles on b.TipoCombustibleId equals tc.Id

                                 select new MapaBomba
                                 {
                                     Id = b.Id,
                                     TipoCombustibleId = tc.Id,
                                     TipoCombustible = tc.Descripcion,
                                     Nombre = b.Descripcion,
                                     Galones = b.CantidadGalones,
                                     Actuales = b.GalonesActuales,
                                     Despachados = b.GalonesDespachados,
                                     Estado = b.IsActive ? "Activo" : "Desactivado",
                                 }).ToList();

                    if (lista.Any())
                            return lista;
                    else
                        return new List<MapaBomba>();
                }
            }
            catch
            {
                return new List<MapaBomba>();
            }
        }

        public List<MapaSimple> ListadoBombasDespacho(int? tcId = null)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    int Tipoc = tcId != null ? Convert.ToInt32(tcId) : 0;
                    var combustibles = tcId == null ? ctx.TiposCombustibles.Select(x => x.Id).ToList() : new List<int>() { Tipoc };

                    var lista = (from b in ctx.Bombas
                                 join t in ctx.TiposCombustibles on b.TipoCombustibleId equals t.Id
                                 where b.IsActive == true && combustibles.Contains(t.Id)
                                 select new MapaSimple
                                 {
                                     Id = b.Id,
                                     Descripcion = t.Descripcion + " | " + b.Descripcion,
                                     GalonesActuales = b.GalonesActuales,
                                     Galones = b.GalonesActuales
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


        public Bombas GetBomba(int Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Bombas.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(Bombas bomb)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(bomb).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(Bombas bomb)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(bomb).State = EntityState.Modified;
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
