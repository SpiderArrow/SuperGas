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
    public class SubtipoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int TipoDetalleId { get; set; }
        public string Descripcion { get; set; }
        public bool IsActive { get; set; }

        public List<MapaEntity> Listado(int? TipoDetalleId)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from sc in ctx.SubtipoDetalles
                                 join c in ctx.TipoDetalles on sc.TipoDetalleId equals c.Id

                                 select new MapaEntity
                                 {
                                     Id = sc.Id,
                                     PadreId = c.Id,
                                     Padre = c.Descripcion,
                                     Descripcion = sc.Descripcion,
                                     Estado = sc.IsActive ? "Activo" : "Desactivado",
                                 }).ToList();

                    if (lista.Any())
                        if (TipoDetalleId != null)
                            return lista.Where(x => x.PadreId == Convert.ToInt32(TipoDetalleId)).ToList();
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


        public SubtipoDetalle GetSubtipoDetalle(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.SubtipoDetalles.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(SubtipoDetalle SubtipoDetalle)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(SubtipoDetalle).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(SubtipoDetalle SubtipoDetalle)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(SubtipoDetalle).State = EntityState.Modified;
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
