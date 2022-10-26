
using Data.Mapas.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Data.Models.Productos
{
    public class Producto
    {
        [Key]
        public long Id { get; set; }
        public int? SubCategoriaId { get; set; }
        public int? MarcaId { get; set; }
        public long? ProveedorId { get; set; }

        [Required]
        public string Descripcion { get; set; }
        public string CodigoBarras { get; set; }

        [Required]
        public decimal PrecioVenta { get; set; }
        public decimal Coste { get; set; }
        public decimal Utilidad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Stock { get; set; }
        public string Notas { get; set; }
        public bool Escalas { get; set; }
        public bool Detalles { get; set; }
        public byte[] Imagen { get; set; }
        public bool Deleted { get; set; }
        public bool ControlStock { get; set; }

        public List<MapaProductos> Listado()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = ctx.Productos.ToList();
                    if (lista.Any())
                    {
                        return lista.Where(x => x.Deleted == false).Select(x => new MapaProductos
                        {
                            Id = x.Id,
                            NombreProducto = x.Descripcion,
                            CodigoBarras = x.CodigoBarras,
                            PrecioVenta = x.PrecioVenta,
                            Coste = x.Coste,
                            Utilidad = x.Utilidad,
                            FechaIngreso = x.FechaIngreso.ToString("dd/MM/yyyy hh:mm tt"),
                            Stock = x.Stock,
                            Notas = x.Notas,
                            ControlStock = x.ControlStock ? "Sí" : "No"
                        }).OrderBy(x => x.Id).ToList();
                    }
                    else
                        return new List<MapaProductos>();
                }
            }
            catch
            {
                return new List<MapaProductos>();
            }
        }


        public Producto GetProducto(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Productos.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public long GetLastId()
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Productos.Max(x => x.Id);
                }
            }
            catch
            {
                return 0;
            }
        }

        public string Update(Producto prod)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(prod).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Inserta(Producto prod)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(prod).State = EntityState.Added;
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
