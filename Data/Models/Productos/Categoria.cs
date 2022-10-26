
using Data.Mapas.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Data.Models.Productos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool IsActive { get; set; }

        public List<MapaEntity> Listado(bool? estado)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var lista = ctx.Categorias.ToList();
                    if (lista.Any())
                        if (estado != null)
                            lista = lista.Where(x => x.IsActive == Convert.ToBoolean(estado)).ToList();
                        else
                            lista = lista.ToList();
                    else
                        return new List<MapaEntity>();

                    return lista.Select(x => new MapaEntity
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        Estado = x.IsActive ? "Activo" : "Desactivado"
                    }).ToList();
                }
            }
            catch
            {
                return new List<MapaEntity>();
            }
        }


        public Categoria GetCategoria(long Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Categorias.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public string Insert(Categoria Categoria)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(Categoria).State = EntityState.Added;
                    ctx.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(Categoria Categoria)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(Categoria).State = EntityState.Modified;
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
