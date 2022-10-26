using Data.Mapas.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Productos
{
    public class TipoDetalle
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
                    var lista = ctx.TipoDetalles.ToList();
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


        public TipoDetalle GetTipoDetalle(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.TipoDetalles.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(TipoDetalle TipoDetalle)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(TipoDetalle).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(TipoDetalle TipoDetalle)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(TipoDetalle).State = EntityState.Modified;
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
