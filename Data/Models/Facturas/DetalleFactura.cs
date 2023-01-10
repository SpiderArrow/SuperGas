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
    public class DetalleFactura
    {
        [Key]
        public long Id { get; set; }
        public long FacturaId { get; set; }
        public decimal CantidadGalones { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Utilidad { get; set; }
        public decimal SubTotal { get; set; }

        public List<DetalleFactura> ListadoDetalleFactura(long idFactura = 0) 
        {
            try
            {
                using (var ctx = new ModelContext()) {
                    var lista = ctx.DetalleFacturas.ToList();
                    if (lista.Any())
                        if(idFactura > 0)
                            return lista.Where(x => x.FacturaId == idFactura).ToList();
                        else
                            return lista;
                    else
                        return new List<DetalleFactura>();
                } 
            }
            catch {
                return new List<DetalleFactura>();
            }
        }

        public List<MapaDetalleFactura> ListadoMapaDetalleFactura(long idFactura = 0)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from df in ctx.DetalleFacturas
                                 join f in ctx.Facturas on df.FacturaId equals f.Id
                                 join dv in ctx.DespachosVehiculos on f.DespachosVehiculoId equals dv.Id
                                 join v in ctx.Vehiculos on dv.VehiculoId equals v.Id
                                 join c in ctx.Cisternas on dv.CisternaId equals c.Id
                                 join g in ctx.Gasolineras on c.GasolineraId equals g.Id

                                 select new MapaDetalleFactura
                                 {
                                     Id = df.Id,
                                     FacturaId = f.Id,
                                     DespachoVehiculoId = f.DespachosVehiculoId,
                                     Vehiculo = v.Nombre,
                                     Cisterna = c.Descripcion,
                                     Gasolinera = g.Nombre,
                                     CantidadGalones = df.CantidadGalones,
                                     Costo = df.Costo,
                                     Precio = df.Precio,
                                     SubTotal = df.SubTotal,
                                 }).ToList();

                    if (lista.Any())
                        if (idFactura > 0)
                            return lista.Where(x => x.FacturaId == idFactura).ToList();
                        else
                            return lista;
                    else
                        return new List<MapaDetalleFactura>();
                }
            }
            catch
            {
                return new List<MapaDetalleFactura>();
            }
        }

        public string Insertar(DetalleFactura detalleFactura)
        {

            try
            {
                using (var ctx = new ModelContext())
                {

                    ctx.Entry(detalleFactura).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }

            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}
