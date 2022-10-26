using Data.Mapas.Usuarios;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Usuarios
{
    public class User : IdentityUser
    {
        public static object Identity { get; internal set; }

        [Required]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public string Privilegios { get; set; }

        public List<MapaUsuarios> Listado()
        {
            try {
                using (var ctx = new ModelContext()) {
                    var lista = ctx.Users.ToList();
                    if (lista.Any())
                    {
                        return lista.Select(x => new MapaUsuarios { 
                            Id = x.Id,
                            NombreCompleto = x.Name,
                            Email = x.Email,
                            UserName = x.UserName,
                            Privilegios = x.Privilegios,
                            Estado = x.IsDeleted == true ? "Desactivado" : "Activo"
                        }).ToList();
                    }
                    else
                        return new List<MapaUsuarios>();
                }
            }
            catch {
                return new List<MapaUsuarios>();
            }
        }


        public User GetUser(string Id)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    return ctx.Users.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch {
                return null;
            }            
        }

        public string Update(User user)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    ctx.Entry(user).State = EntityState.Modified;
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
