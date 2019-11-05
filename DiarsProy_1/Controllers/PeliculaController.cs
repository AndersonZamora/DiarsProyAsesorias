using DiarsProy_1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using DiarsProy_1.Models;

namespace DiarsProy_1.Controllers
{
    public class PeliculaController : Controller
    {
        CieneContext context = new CieneContext();
        private IValidaciones validaciones;
        public PeliculaController(IValidaciones validaciones)
        {
            this.validaciones = validaciones;

        }
        public ActionResult Index()
        {
            var peliculas = context.Peliculas.Include(a => a.Director); ///using System.Data.Entity;

            return View("Index",peliculas);
        }
        [HttpGet]
        public ViewResult Guardar()
        {
            var directores =  context.Directors.ToList(); ///lista diretores
            ViewBag.directores = new SelectList(directores, "IdDirector", "Nombre");
            return View("Guardar", new Pelicula());
        }
        [HttpPost]
        public ActionResult PeliculaGuardar(Pelicula pelicula)
        {
            var directores = context.Directors.ToList();
            ViewBag.directores = new SelectList(directores, "IdDirector", "Nombre");

            if (String.IsNullOrEmpty(pelicula.NombrePelicula))
                ModelState.AddModelError("NombrePelicula", "Nombre de la pelicula es obligatori");

            if(!validaciones.validarLetra(pelicula.NombrePelicula))
                ModelState.AddModelError("NombrePelicula","Ingrese un Nombre valido");

            if (pelicula.Año == null || pelicula.Año == "")
                ModelState.AddModelError("Año", "El Año es obligatorio");

            if (!validaciones.validarnUMEROS(pelicula.Año))
                ModelState.AddModelError("Año", "El formato de año es incorrecto");

            if (!ModelState.IsValid)
            {
                return View("Guardar", pelicula);
            }

            context.Peliculas.Add(pelicula);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        //public bool validarnUMEROS(string numString)
        //{
        //    try
        //    {
        //        char[] charArr = numString.ToCharArray();
        //        foreach (char cd in charArr)
        //        {
        //            if (!char.IsNumber(cd))
        //                return false;
        //        }
              
        //    }
        //    catch(Exception e)
        //    {

        //    }
        //    return true;
        //}
    
    }

}