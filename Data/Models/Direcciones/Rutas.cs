using Data.Mapas._helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Direcciones
{
    public class Rutas
    {
        [Key]
        public int Id { get; set; }
        public string CodigoRuta { get; set; }
        public bool IsActive { get; set; }


        public List<MapaEntity> Listado(bool? estado)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = ctx.Rutas.ToList();
                    if (lista.Any())
                        if (estado != null)
                            lista = lista.Where(x => x.IsActive == Convert.ToBoolean(estado)).ToList();
                        else
                            lista = lista.ToList();
                    else
                        return new List<MapaEntity>();

                    return lista.Select(x => new MapaEntity
                    {
                        Id = x.Id,
                        Descripcion = x.CodigoRuta,
                        Estado = x.IsActive ? "Activo" : "Inactivo"
                    }).ToList();
                }
            }
            catch
            {
                return new List<MapaEntity>();
            }
        }

        public List<MapaAsigna> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = ctx.Rutas.ToList();
                    if (lista.Any())
                    {
                        return lista.Select(x => new MapaAsigna
                        {
                            Id = x.Id,
                            Entity1 = x.CodigoRuta,
                            Estado = x.IsActive ? "Activo" : "Inactivo"
                        }).ToList();
                    }
                    else
                        return new List<MapaAsigna>();
                }
            }
            catch
            {
                return new List<MapaAsigna>();
            }
        }


        public Rutas GetRuta(int Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Rutas.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(Rutas rt)
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

        public string Update(Rutas rt)
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
    }
}
