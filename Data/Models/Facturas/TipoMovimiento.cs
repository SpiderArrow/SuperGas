using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Facturas
{
    public class TipoMovimiento
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool IsActive { get; set; }


        public List<TipoMovimiento> Listado(bool? estado)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = ctx.TipoMovimientos.ToList();
                    if (lista.Any())
                        if(estado != null)
                            return lista.Where(x => x.IsActive == Convert.ToBoolean(estado)).ToList();
                        else
                            return lista.ToList();
                    else
                        return new List<TipoMovimiento>();
                }
            }
            catch
            {
                return new List<TipoMovimiento>();
            }
        }


        public TipoMovimiento GetTipoMovimiento(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.TipoMovimientos.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(TipoMovimiento TipoMovimiento)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(TipoMovimiento).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(TipoMovimiento TipoMovimiento)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(TipoMovimiento).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(TipoMovimiento TipoMovimiento)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(TipoMovimiento).State = EntityState.Deleted;
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
