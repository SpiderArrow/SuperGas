using Data.Mapas._helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Limpieza
{
    public class EstadoLimpieza
    {
        [Key]
        public int Id { get; set; }
        public string Estado { get; set; }
        public bool IsActive { get; set; }


        public List<MapaEntity> Listado(bool? estado)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = ctx.EstadoLimpiezas.ToList();
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
                        Descripcion = x.Estado,
                        Estado = x.IsActive ? "Activa" : "Desactivada"
                    }).ToList();
                }
            }
            catch
            {
                return new List<MapaEntity>();
            }
        }


        public EstadoLimpieza GetMarca(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.EstadoLimpiezas.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(EstadoLimpieza el)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(el).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(EstadoLimpieza el)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(el).State = EntityState.Modified;
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
