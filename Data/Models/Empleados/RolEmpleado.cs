using Data.Mapas._helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Empleados
{
    public class RolEmpleado
    {
        [Key]
        public int Id { get; set; }
        public string Rol { get; set; }
        public bool IsActive { get; set; }


        public List<MapaEntity> Listado(bool? estado)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = ctx.RolEmpleados.ToList();
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
                        Descripcion = x.Rol,
                        Estado = x.IsActive ? "Activo" : "Inactivo"
                    }).ToList();
                }
            }
            catch
            {
                return new List<MapaEntity>();
            }
        }

        public RolEmpleado GetRol(int Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.RolEmpleados.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(RolEmpleado rol)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(rol).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(RolEmpleado rol)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(rol).State = EntityState.Modified;
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
