using DiarsProy_1.DB.Map;
using DiarsProy_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DiarsProy_1.DB
{
    /// <summary>
    /// Crear el contexto de la base de datos
    /// </summary>
    public class CieneContext : DbContext
    {
        ///Qué entidades están incluidas en el modelo de datos.
        ///Una versión no genérica de DbSer <TEntity>
        ///que se puede utilizar cuando no se conoce el tipo de entidad 
        ///en el momento de la compilación
        public DbSet<Director> Directors { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new MapDirector());
            modelBuilder.Configurations.Add(new MapPelicula());

        }
    }
}