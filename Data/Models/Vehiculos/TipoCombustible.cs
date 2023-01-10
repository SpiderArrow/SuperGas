using Data.Mapas._helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Vehiculos
{
    public class TipoCombustible
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool IsActive { get; set; }


        public List<MapaEntity> Listado(bool? estado)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = ctx.TiposCombustibles.ToList();
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
                        Descripcion = x.Descripcion,
                        Estado = x.IsActive ? "Activo" : "Desactivado"
                    }).ToList();
                }
            }
            catch
            {
                return new List<MapaEntity>();
            }
        }


        public TipoCombustible Get(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.TiposCombustibles.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(TipoCombustible tc)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(tc).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(TipoCombustible tc)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(tc).State = EntityState.Modified;
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
