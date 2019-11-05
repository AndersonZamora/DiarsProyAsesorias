using DiarsProy_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DiarsProy_1.DB.Map
{
    ///Inicializa una nueva instancia de EntityTypeConfiguration<Pelicula>
    public class MapPelicula : EntityTypeConfiguration<Pelicula>
    {
        public MapPelicula()
        {
            ToTable("Pelicula");
            /// signa al campo Clave primaria en una base de datos:
            HasKey(a => a.IdPelicula);
            /// configurar las propiedades de clave externa utilizando el método HasRequired
            HasRequired(a => a.Director)  ///especificar el tipo de relación en la que participa esta entidad
                .WithMany() ///se usan para las propiedades de navegación de la colección.
                .HasForeignKey(a => a.DirectorId);
            ///Este método toma una expresión lambda que representa la propiedad que se utilizará como clave foránea.
        }
    }
}