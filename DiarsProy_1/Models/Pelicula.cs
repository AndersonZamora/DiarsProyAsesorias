using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiarsProy_1.Models
{
    public class Pelicula
    {
        public int IdPelicula { get; set; }
        public string NombrePelicula { get; set; }
        public string Año { get; set; }
        public Director Director { get; set; }
        public int DirectorId { get; set; }

    }
}