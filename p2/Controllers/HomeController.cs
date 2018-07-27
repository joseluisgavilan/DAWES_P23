using p2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace p2.Controllers
{

    public class HomeController : Controller

    {

        public ActionResult Index()

        {
            ViewBag.Message = "En esta página encontraras las películas ";
            ViewBag.Title = "Películas";
            ViewBag.Pelicula= Película.GetTuPelículaFavorita();
            ViewBag.ListaPeliculas = Película.GetListaPelículas();

            return View();
        }


        public ActionResult About()

        {
            ViewBag.Message = "En esta página encontrarás Directores/as, Actores y Actrices";
            ViewBag.Title = "Directores/as, Actores y Actrices";
            ViewBag.Director = Persona.GetFavorita(true);
            ViewBag.Actor = Persona.GetFavorita(false);
            ViewBag.ListaPersonas= Persona.GetListaPersonas();
            
            return View();
        }


        public ActionResult Contact()

        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}