using Data.Mapas.Gasolineras;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Gasolineras
{
    public class Gasolinera
    {
        [Key]
        public long Id { get; set; }
        public int ZonaId { get; set; }
        public int EmpresaId { get; set; }

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefonos1{ get; set; }
        public string Telefonos2 { get; set; }
        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Nit { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Observaciones { get; set; }
        public bool IsActive { get; set; }

        public List<MapaGasolinera> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from g in ctx.Gasolineras
                                 join e in ctx.Empresas on g.EmpresaId equals e.Id
                                 join z in ctx.Zonas on g.ZonaId equals z.Id
                                 join m in ctx.Municipios on z.MunicipioId equals m.Id
                                 join d in ctx.Departamentos on m.DepartamentoId equals d.Id
                                 where g.IsActive == true
                                 select new MapaGasolinera
                                 {
                                     Id = g.Id,
                                     Nombre = g.Nombre,
                                     Empresa = e.Descripcion,
                                     Direccion = z.Descripcion+","+m.Descripcion+","+d.Descripcion,
                                     ZonaId = z.Id,
                                     DeptoId = d.Id,
                                     MunicipioId = m.Id,
                                     Correo = g.Correo,
                                     Telefonos1 = g.Telefonos1,
                                     Telefonos2 = g.Telefonos2,
                                     Celular1 = g.Celular1,
                                     Celular2 = g.Celular2,
                                     Nit = g.Nit,
                                     Estado = g.IsActive ? "Activo" : "Desactivado",
                                     FechaIngreso = g.FechaIngreso,
                                     Observaciones = g.Observaciones
                                 }).ToList();
                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaGasolinera>();
                }
            }
            catch
            {
                return new List<MapaGasolinera>();
            }
        }


        public List<MapaSimple> ListadoGasolineras()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from g in ctx.Gasolineras
                                 join e in ctx.Empresas on g.EmpresaId equals e.Id
                                 where g.IsActive == true
                                 select new MapaSimple
                                 {
                                     Id = g.Id,
                                     Descripcion = e.Descripcion + " | " + g.Nombre
                                 }).ToList();

                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaSimple>();
                }
            }
            catch
            {
                return new List<MapaSimple>();
            }
        }

        public Gasolinera GetGasolinera(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Gasolineras.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Update(Gasolinera gaso)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(gaso).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Inserta(Gasolinera gaso)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(gaso).State = EntityState.Added;
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
