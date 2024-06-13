using routingA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace routingA.Controllers
{
    public class PeliculaController : Controller
    {
        
        public ActionResult Index()
        {
            return View("Peliculas");
        }
        public ActionResult Peliculas()
        {
            return View("ListaPeliculas");
        }

      public ActionResult GetContent()
        {
            return Content("<h1><b>Hola desde MVC</b></h1>");
        }

        public ContentResult GetContentResult()
        {
            return Content("<h1><b>Hola desde MVC y contenido</b></h1>");
        }

        public ViewResult GetViewExample() 
        {

            return View("ListaPeliculas");
        }
        //Transacciones bancarias -> Retirar Dinero va regresar Dinero simpre y cuando este disponible lo solicitado
        public ActionResult RetirarDinero ()
        {
            int SaldoTotal = 2000;
            int SaldoSolicitado = 1050;

            if(SaldoSolicitado <= SaldoTotal)
            {
                return View("Saldo");
            }
            else
            {
                return Content("<h1><b>Saldo Insuficiente</b></h1>");
            }



            return Content("<h1><b>Hola desde MVC</b></h1>");
        }

        //JsonResult Formato Ligero para el intercambio de datos o informacion -> string

        public JsonResult GetJson()
        {
            var peliculas = getPeliculaslist();
            return Json(peliculas,JsonRequestBehavior.AllowGet);
         }

        public List<PeliculaModel> getPeliculaslist() 
        { 
           PeliculaModel pelicula1 = new PeliculaModel();
            pelicula1.Id = 1;
            pelicula1.Titulo = "Pepito el Guayaco";
            pelicula1.Duracion = 150;
            pelicula1.Genero = "Drama y Suspenso";

            PeliculaModel pelicula2 = new PeliculaModel();
            pelicula2.Id = 2;
            pelicula2.Titulo = "Herodes";
            pelicula2.Duracion = 150;
            pelicula2.Genero = "Drama y Accion";

            List<PeliculaModel> peliculasList = new List<PeliculaModel>();
            peliculasList.Add(pelicula1);
            peliculasList.Add(pelicula2);

            return peliculasList;


        }



    }
}