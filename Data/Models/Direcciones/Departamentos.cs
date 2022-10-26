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
    public class Departamentos
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
                    var lista = ctx.Departamentos.ToList();
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
                        Estado = x.IsActive ? "Activo" : "Inactivo"
                    }).ToList();
                }
            }
            catch
            {
                return new List<MapaEntity>();
            }
        }


        public Departamentos GetDepto(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Departamentos.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(Departamentos depto)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(depto).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(Departamentos depto)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(depto).State = EntityState.Modified;
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
