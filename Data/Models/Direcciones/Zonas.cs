using Data.Mapas._helpers;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Direcciones
{
    public class Zonas
    {
        [Key]
        public int Id { get; set; }
        public int? MunicipioId { get; set; }
        public string Descripcion { get; set; }
        public bool IsActive { get; set; }

        public List<MapaEntity> Listado(int? MunicipioId)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from z in ctx.Zonas
                                 join m in ctx.Municipios on z.MunicipioId equals m.Id

                                 select new MapaEntity
                                 {
                                     Id = z.Id,
                                     PadreId = m.Id,
                                     Padre = m.Descripcion,
                                     Descripcion = z.Descripcion,
                                     Estado = z.IsActive ? "Activo" : "Inactivo",
                                 }).ToList();

                    if (lista.Any())
                        if (MunicipioId != null)
                            return lista.Where(x => x.PadreId == Convert.ToInt32(MunicipioId)).ToList();
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


        public Zonas GetZona(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Zonas.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(Zonas zona)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(zona).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(Zonas zona)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(zona).State = EntityState.Modified;
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
