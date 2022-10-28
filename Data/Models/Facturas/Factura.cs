using Data.Mapas.Facturas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Facturas
{
    public class Factura
    {
        [Key]
        public long Id { get; set; }
        public int DespachosVehiculoId { get; set; }
        public int TipoMovimientoId { get; set; }
        public long GasolineraId { get; set; }
        public string UserId { get; set; }
        public string NoFactura { get; set; }
        public string Serie { get; set; }

        public DateTime FechaVenta { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string NIT { get; set; }       
        public decimal TotalFactura { get; set; }


        public List<MapaFactura> Listado()
        {
            List<MapaFactura> lista = new List<MapaFactura>();
            try
            {
                using (var ctx = new ModelContext())
                {
                    lista = (from f in ctx.Facturas.AsEnumerable() 
                             join u in ctx.Users on f.UserId equals u.Id
                             orderby f.FechaVenta descending

                             select new MapaFactura
                             { 
                                 Id = f.Id,
                                 FechaVenta = f.FechaVenta.ToString("dd/MM/yyyy hh:mm tt"),
                                 Vendedor = u.Name,
                                 NoFactura = f.NoFactura,
                                 Nombre = f.Nombre,
                                 Direccion = f.Direccion,
                                 NIT = f.NIT,
                                 TotalFactura = f.TotalFactura
                             }).ToList();

                    return lista;
                }
            }
            catch
            {
                return lista;
            }
        }

        public string LastNoFactura() {
            try
            {
                using (var ctx = new ModelContext()) 
                {
                    var facturas = ctx.Facturas.ToList();
                    if (facturas.Any())
                    {
                        facturas = facturas.OrderByDescending(x => x.NoFactura).ToList();
                        return facturas.FirstOrDefault().NoFactura;
                    }
                    else 
                        return "";                    
                }
            }
            catch {
                return "";
            }
        }

        public string Insertar(Factura factura) {

            try
            {
                using (var ctx = new ModelContext()) {

                    ctx.Entry(factura).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }

            }
            catch (Exception e) {
                return e.Message;
            }
                
        }

        public long LastIdFactura()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var facturas = ctx.Facturas.ToList();
                    if (facturas.Any())
                    {
                        facturas = facturas.OrderByDescending(x => x.Id).ToList();
                        return facturas.FirstOrDefault().Id;
                    }
                    else
                        return 0;
                }
            }
            catch
            {
                return 0;
            }
        }


        public Factura GetFactura(long idFactura) {

            try
            {
                using (var ctx = new ModelContext())
                {
                    var facturas = ctx.Facturas.ToList();
                    if (facturas.Any())
                    {
                        return facturas.Where(x => x.Id == idFactura).FirstOrDefault();
                    }
                    else
                        return null;
                }
            }
            catch
            {
                return null;
            }
        }

    }
}
