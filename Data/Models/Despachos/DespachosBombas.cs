using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Mapas.Despachos;

namespace Data.Models.Despachos
{
    public class DespachosBombas
    {
        [Key]
        public int Id { get; set; }
        public long EmpleadoId { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int TipoCombustibleId { get; set; }
        public int BombaId { get; set; }
        public long VehiculoId { get; set; }
        public decimal GalonesDespachados { get; set; }
        public string Observaciones { get; set; }
        public string UsuarioIngreso { get; set; }
        public List<MapaDespachosBombas> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from d in ctx.DespachosBombas
                                 join tc in ctx.TiposCombustibles on d.TipoCombustibleId equals tc.Id
                                 join b in ctx.Bombas on d.BombaId equals b.Id
                                 join c in ctx.Vehiculos on d.VehiculoId equals c.Id
                                 
                                 select new MapaDespachosBombas
                                 {
                                     Id = d.Id,
                                     FechaDespacho = d.FechaDespacho,
                                     BombaId = b.Id,
                                     CamionId = c.Id,
                                     TipoCombustibleId = tc.Id,
                                     Bomba = b.Descripcion,
                                     Camion = c.Nombre,
                                     TipoCombustible = tc.Descripcion,
                                     GalonesDespachados = d.GalonesDespachados,
                                     Observaciones = d.Observaciones
                                 }).ToList();

                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaDespachosBombas>();
                }
            }
            catch
            {
                return new List<MapaDespachosBombas>();
            }
        }


        public DespachosBombas GetDespacho(int Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.DespachosBombas.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(DespachosBombas despacho)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(despacho).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(DespachosBombas despacho)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(despacho).State = EntityState.Modified;
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
