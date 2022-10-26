using Data.Mapas.Limpieza;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Limpieza
{
    public class HistorialLimpieza
    {
        [Key]
        public long Id { get; set; }
        public long? GasolineraId { get; set; }
        public long? VehiculoId { get; set; }
        public int? BombasId { get; set; }       
        public int? PistasId { get; set; }
        public int EstadoLimpiezaId { get; set; }
        public long EncargadoId { get; set; }

        public string HoraInicio { get; set; }
        public string HoraFinal { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaLimpieza { get; set; }
        public DateTime ProximaLimpieza { get; set; }
        public bool IsActive { get; set; }


        public List<MapaLimpieza> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from h in ctx.HistorialLimpiezas
                                 join el in ctx.EstadoLimpiezas on h.EstadoLimpiezaId equals el.Id
                                 join e in ctx.Empleados on h.EncargadoId equals e.Id
                                 where h.IsActive == true
                                 select new MapaLimpieza
                                 {
                                     Id = h.Id,
                                     GasolineraId = h.GasolineraId,
                                     VehiculoId = h.VehiculoId,
                                     BombasId = h.BombasId,
                                     PistasId = h.PistasId,
                                     EstadoLimpiezaId = h.EstadoLimpiezaId,
                                     EncargadoId = h.EncargadoId,

                                     Encargado = e.Nombres + " " + e.Apellidos,
                                     Estado = el.Estado,

                                     HoraInicio = h.HoraInicio,
                                     HoraFinal = h.HoraFinal,
                                     Observaciones = h.Observaciones,
                                     FechaLimpieza = h.FechaLimpieza,
                                     ProximaLimpieza = h.ProximaLimpieza,
                                 }).ToList();
                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaLimpieza>();
                }
            }
            catch
            {
                return new List<MapaLimpieza>();
            }
        }


        public List<MapaLimpieza> ListadoJoin()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from h in ctx.HistorialLimpiezas
                                 join g in ctx.Gasolineras on h.GasolineraId equals g.Id
                                 join v in ctx.Vehiculos on h.VehiculoId equals v.Id
                                 join b in ctx.Bombas on h.BombasId equals b.Id
                                 join p in ctx.Pistas on h.PistasId equals p.Id
                                 join el in ctx.EstadoLimpiezas on h.EstadoLimpiezaId equals el.Id
                                 join e in ctx.Empleados on h.EncargadoId equals e.Id
                                 where h.IsActive == true
                                 select new MapaLimpieza
                                 {
                                     Id = h.Id,
                                     GasolineraId = h.GasolineraId,
                                     VehiculoId = h.VehiculoId,
                                     BombasId = h.BombasId,
                                     PistasId = h.PistasId,
                                     EstadoLimpiezaId = h.EstadoLimpiezaId,
                                     EncargadoId = h.EncargadoId,
                                     
                                     Encargado = e.Nombres+" "+e.Apellidos,
                                     Gasolinera = g.Nombre,
                                     Camion = v.Nombre,
                                     Bomba = b.Descripcion,
                                     Pista = p.Descripcion,
                                     Estado = el.Estado,
                                     
                                     HoraInicio = h.HoraInicio,
                                     HoraFinal = h.HoraFinal,
                                     Observaciones = h.Observaciones,
                                     FechaLimpieza = h.FechaLimpieza,
                                     ProximaLimpieza = h.ProximaLimpieza,
                                 }).ToList();
                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaLimpieza>();
                }
            }
            catch
            {
                return new List<MapaLimpieza>();
            }
        }

        public HistorialLimpieza GetLimpieza(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.HistorialLimpiezas.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Update(HistorialLimpieza lmp)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(lmp).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Inserta(HistorialLimpieza lmp)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(lmp).State = EntityState.Added;
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
