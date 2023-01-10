using Data.Mapas._helpers;
using Data.Mapas.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Empleados
{
    public class Empleado
    {
        [Key]
        public long Id { get; set; }
        public int? RolEmpleadoId { get; set; }
        public int? ZonaId { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public string CodigoEmpleado { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Nit { get; set; }
        public string DPI { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }
        public int Edad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool IsActive { get; set; }

        public List<MapaEmpleado> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from e in ctx.Empleados
                                 join r in ctx.RolEmpleados on e.RolEmpleadoId equals r.Id
                                 join z in ctx.Zonas on e.ZonaId equals z.Id
                                 join m in ctx.Municipios on z.MunicipioId equals m.Id
                                 join d in ctx.Departamentos on m.DepartamentoId equals d.Id
                                 where e.IsActive == true
                                 select new MapaEmpleado
                                 {
                                     Id = e.Id,                                     
                                     Direccion = z.Descripcion + "," + m.Descripcion + "," + d.Descripcion,
                                     ZonaId = z.Id,
                                     DeptoId = d.Id,
                                     MunicipioId = m.Id,
                                     RolEmpleadoId = r.Id,
                                     Rol = r.Rol,
                                     Nombres = e.Nombres,
                                     Apellidos = e.Apellidos,
                                     Correo = e.Correo,
                                     CodigoEmpleado = e.CodigoEmpleado,
                                     Telefono = e.Telefono,
                                     Celular = e.Celular,
                                     Nit = e.Nit,
                                     DPI = e.DPI,
                                     Edad = e.Edad,
                                     Estado = e.IsActive ? "Activo" : "Desactivado",
                                     FechaIngreso = e.FechaIngreso,
                                     FechaNacimiento = e.FechaNacimiento,
                                     Observaciones = e.Observaciones
                                 }).ToList();
                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaEmpleado>();
                }
            }
            catch
            {
                return new List<MapaEmpleado>();
            }
        }

        public List<MapaEmpleadoSimple> ListadoByRol(string rol)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from e in ctx.Empleados
                                 join r in ctx.RolEmpleados on e.RolEmpleadoId equals r.Id
                                 where e.IsActive == true &&
                                       r.Rol.ToUpper().Contains(rol.ToUpper())
                                 select new MapaEmpleadoSimple
                                 {
                                     Id = e.Id,
                                     NombreCompleto = e.Nombres+" "+e.Apellidos     
                                 }).ToList();
                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaEmpleadoSimple>();
                }
            }
            catch
            {
                return new List<MapaEmpleadoSimple>();
            }
        }

        public List<MapaEmpleadoSimple> ListadoEmp()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from e in ctx.Empleados
                                 where e.IsActive == true
                                 select new MapaEmpleadoSimple
                                 {
                                     Id = e.Id,
                                     NombreCompleto = e.Nombres + " " + e.Apellidos
                                 }).ToList();
                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaEmpleadoSimple>();
                }
            }
            catch
            {
                return new List<MapaEmpleadoSimple>();
            }
        }

        public Empleado GetEmpleado(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Empleados.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Update(Empleado emp)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(emp).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Inserta(Empleado emp)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(emp).State = EntityState.Added;
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
