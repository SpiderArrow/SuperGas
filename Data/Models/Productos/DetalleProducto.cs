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
    public class DetalleProducto
    {
       [Key]
        public int Id { get; set; }
        public int SubtipoDetalleId { get; set; }
        public long ProductoId { get; set; }
        public int Stock { get; set; }

        public List<DetalleProducto> Listado(long? ProductoId)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = ctx.DetalleProductos.ToList();
                    if (lista.Any())
                        if (ProductoId != null)
                            return lista.Where(x => x.ProductoId == Convert.ToInt64(ProductoId)).ToList();
                        else
                            return lista.ToList();
                    else
                        return new List<DetalleProducto>();
                }
            }
            catch
            {
                return new List<DetalleProducto>();
            }
        }

        public List<MapaIngresoDetalles> ListadoDetalles(long ProductoId)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from dp in ctx.DetalleProductos
                                 join td in ctx.SubtipoDetalles on dp.SubtipoDetalleId equals td.Id
                                 join de in ctx.TipoDetalles on td.TipoDetalleId equals de.Id
                                 where dp.ProductoId == ProductoId
                                 select new MapaIngresoDetalles { 
                                    Id = dp.Id,
                                    ProductoId = dp.ProductoId,
                                    SubTipoDetalleId = td.Id,
                                    TipoDetalleId = de.Id,
                                    TipoDetalle = de.Descripcion,
                                    SubTipoDetalle = td.Descripcion,
                                    Stock = dp.Stock
                                 }).ToList();

                    return lista;
                }
            }
            catch
            {
                return new List<MapaIngresoDetalles>();
            }
        }


        public DetalleProducto GetDetalleProducto(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.DetalleProductos.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(DetalleProducto DetalleProducto)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(DetalleProducto).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message; 
            }
        }

        public string Update(DetalleProducto DetalleProducto)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(DetalleProducto).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var entity = ctx.DetalleProductos.Where(x => x.Id == id).FirstOrDefault();
                    if (entity != null)
                    {
                        ctx.Entry(entity).State = EntityState.Deleted;
                        ctx.SaveChanges();
                        return "";
                    }
                    else
                    {
                        return "No se encontraron datos para eliminar";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
