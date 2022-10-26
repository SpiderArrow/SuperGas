using Data.Mapas.Productos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Productos
{
    public class SubCategoria
    {
        public int Id { get; set; }
        public int? CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public bool IsActive { get; set; }

        public List<MapaEntity> Listado(int? CategoriaId)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = (from sc in ctx.SubCategorias
                                 join c in ctx.Categorias on sc.CategoriaId equals c.Id

                                 select new MapaEntity
                                 {
                                     Id = sc.Id,
                                     PadreId = c.Id,
                                     Padre = c.Descripcion,
                                     Descripcion = sc.Descripcion,
                                     Estado = sc.IsActive ? "Activo" : "Desactivado",
                                 }).ToList();

                    if (lista.Any())
                        if (CategoriaId != null)
                            return lista.Where(x => x.PadreId == Convert.ToInt32(CategoriaId)).ToList();
                        else
                            return lista;
                    else
                        return new List<MapaEntity>();
                }
            }
            catch
            {
                return new List<MapaEntity>();
            }
        }


        public SubCategoria GetSubCategoria(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.SubCategorias.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(SubCategoria SubCategoria)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(SubCategoria).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(SubCategoria SubCategoria)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(SubCategoria).State = EntityState.Modified;
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
