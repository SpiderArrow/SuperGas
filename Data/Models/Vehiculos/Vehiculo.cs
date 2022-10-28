using Data.Mapas.Vehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Vehiculos
{
    public class Vehiculo
    {
        [Key]
        public long Id { get; set; }
        public int MarcaId { get; set; }
        public int TipoCombustibleId { get; set; }
        public int EmpleadoId { get; set; }
        public int Kilometraje { get; set; }

        public string Nombre { get; set; }
        public string Placa { get; set; }
        public string Codigo { get; set; }
        public string Modelo { get; set; }
        public string NumeroMotor { get; set; }
        public decimal CantidadGalones { get; set; }
        public decimal GalonesActuales { get; set; }
        public decimal GalonesDespachados { get; set; }

        public string Observaciones { get; set; }
        public bool IsActive { get; set; }

        public List<MapaVehiculos> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from v in ctx.Vehiculos
                                 join tc in ctx.TiposCombustibles on v.TipoCombustibleId equals tc.Id
                                 join m in ctx.Marcas on v.MarcaId equals m.Id
                                 join e in ctx.Empleados on v.EmpleadoId equals e.Id
                                 where v.IsActive == true

                                 select new MapaVehiculos
                                 {
                                     Id = v.Id,
                                     TipoCombustibleId = v.TipoCombustibleId,
                                     MarcaId = m.Id,
                                     EmpleadoId = e.Id,
                                     Marca = m.Descripcion,
                                     TipoCombustible = tc.Descripcion,
                                     Encargado = e.Nombres+" "+e.Apellidos,
                                     Kilometraje = v.Kilometraje,
                                     Nombre = v.Nombre,
                                     Placa = v.Placa,
                                     Codigo = v.Codigo,
                                     Modelo = v.Modelo,
                                     NumeroMotor = v.NumeroMotor,
                                     Observaciones = v.Observaciones,
                                     CantidadGalones = v.CantidadGalones,
                                     GalonesActuales = v.GalonesActuales,
                                     GalonesDespachados = v.GalonesDespachados,
                                     Estado = v.IsActive ? "Activo" : "Desactivado",
                                 }).ToList();

                    if (lista.Any())
                            return lista;
                    else
                        return new List<MapaVehiculos>();
                }
            }
            catch
            {
                return new List<MapaVehiculos>();
            }
        }


        public List<MapaVehiculosSimple> ListadoVehiculos(int? tcId = null)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    int Tipoc = tcId != null ? Convert.ToInt32(tcId) : 0;
                    var combustibles = tcId == null ? ctx.TiposCombustibles.Select(x => x.Id).ToList() : new List<int>() { Tipoc };

                    var lista = (from v in ctx.Vehiculos
                                 join tc in ctx.TiposCombustibles on v.TipoCombustibleId equals tc.Id
                                 where v.IsActive == true && combustibles.Contains(v.TipoCombustibleId)
                                 select new MapaVehiculosSimple
                                 {
                                     Id = v.Id,
                                     DescripcionVehiculo = v.Codigo +" | "+v.Nombre,
                                     GalonesActuales = v.GalonesActuales,
                                     Galones = v.CantidadGalones
                                 }).ToList();

                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaVehiculosSimple>();
                }
            }
            catch
            {
                return new List<MapaVehiculosSimple>();
            }
        }

        public Vehiculo GetVehiculo(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Vehiculos.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(Vehiculo vehiculo)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(vehiculo).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(Vehiculo vehiculo)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(vehiculo).State = EntityState.Modified;
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
