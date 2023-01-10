using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Mapas.Entradas;

namespace Data.Models.Entradas
{
    public class HistorialEntradas
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int TipoCombustibleId { get; set; }
        public int BombaId { get; set; }
        public decimal GalonesDisponiblesBomba { get; set; }
        public decimal GalonesEntrada { get; set; }

        public List<MapaEntradas> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from e in ctx.HistorialEntradas
                                 join tc in ctx.TiposCombustibles on e.TipoCombustibleId equals tc.Id
                                 join b in ctx.Bombas on e.BombaId equals b.Id

                                 select new MapaEntradas
                                 {
                                     Id = e.Id,
                                     FechaEntrada = e.FechaEntrada,
                                     TipoCombustibleId = tc.Id,
                                     TipoCombustible = tc.Descripcion,
                                     BombaId = b.Id,
                                     Bomba = b.Descripcion,
                                     GalonesDisponiblesBomba = e.GalonesDisponiblesBomba,
                                     GalonesEntrada = e.GalonesEntrada
                                 }).ToList();

                    if (lista.Any())
                        return lista;
                    else
                        return new List<MapaEntradas>();
                }
            }
            catch
            {
                return new List<MapaEntradas>();
            }
        }

        public HistorialEntradas GetEntrada(int Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.HistorialEntradas.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(HistorialEntradas entrada)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(entrada).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(HistorialEntradas entrada)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(entrada).State = EntityState.Deleted;
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
