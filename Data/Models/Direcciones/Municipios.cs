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
    public class Municipios
    {
        [Key]
        public int Id { get; set; }
        public int? DepartamentoId { get; set; }
        public string Descripcion { get; set; }
        public bool IsActive { get; set; }

        public List<MapaEntity> Listado(int? DeptoId)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from m in ctx.Municipios
                                 join d in ctx.Departamentos on m.DepartamentoId equals d.Id

                                 select new MapaEntity
                                 {
                                     Id = m.Id,
                                     PadreId = d.Id,
                                     Padre = d.Descripcion,
                                     Descripcion = m.Descripcion,
                                     Estado = m.IsActive ? "Activo" : "Inactivo",
                                 }).ToList();

                    if (lista.Any())
                        if (DeptoId != null)
                            return lista.Where(x => x.PadreId == Convert.ToInt32(DeptoId)).ToList();
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


        public Municipios GetMunicipio(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Municipios.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(Municipios mpio)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(mpio).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(Municipios mpio)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(mpio).State = EntityState.Modified;
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
