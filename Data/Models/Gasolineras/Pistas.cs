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
    public class Pistas
    {
        [Key]
        public int Id { get; set; }
        public long? GasolineraId { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public bool IsActive { get; set; }

        public List<MapaPista> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from p in ctx.Pistas
                                 join g in ctx.Gasolineras on p.GasolineraId equals g.Id
                                 where p.IsActive == true
                                 select new MapaPista
                                 {
                                     Id = p.Id,
                                     Gasolinera = g.Nombre,
                                     GasolineraId = g.Id,
                                     Observaciones = p.Observaciones,
                                     Descripcion = p.Descripcion,
                                     Estado = p.IsActive ? "Activo" : "Desactivado",
                                 }).ToList();

                    if (lista.Any())
                            return lista;
                    else
                        return new List<MapaPista>();
                }
            }
            catch
            {
                return new List<MapaPista>();
            }
        }


        public Pistas GetPista(int Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Pistas.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(Pistas pista)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(pista).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(Pistas pista)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(pista).State = EntityState.Modified;
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
