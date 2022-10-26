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
    public class PrecioGalon
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaPrecio { get; set; }
        public int TipoCombustibleId { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public decimal Utilidad { get; set; }
        
        public List<MapaPrecioGalon> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from p in ctx.PrecioGalon
                                 join tc in ctx.TiposCombustibles on p.TipoCombustibleId equals tc.Id

                                 select new MapaPrecioGalon
                                 {
                                     Id = p.Id,
                                     TipoCombustibleId = tc.Id,
                                     TipoCombustible = tc.Descripcion,
                                     FechaPrecio = p.FechaPrecio,
                                     Precio = p.Precio,
                                     Costo = p.Costo,
                                     Utilidad = p.Utilidad,
                                 }).ToList();

                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaPrecioGalon>();
                }
            }
            catch
            {
                return new List<MapaPrecioGalon>();
            }
        }

        public PrecioGalon GetPrecioGolan(int id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.PrecioGalon.Where(x => x.Id == id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public PrecioGalon GetByFechaTipo(DateTime Fecha, int TipoCombustibleId)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.PrecioGalon.Where(x => x.FechaPrecio == Fecha && x.TipoCombustibleId == TipoCombustibleId).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<PrecioGalon> GetByFecha(DateTime Fecha)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.PrecioGalon.Where(x => x.FechaPrecio == Fecha).ToList();
                }
            }
            catch
            {
                return new List<PrecioGalon>();
            }
        }

        public string Insert(PrecioGalon precio)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(precio).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(PrecioGalon precio)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(precio).State = EntityState.Deleted;
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
