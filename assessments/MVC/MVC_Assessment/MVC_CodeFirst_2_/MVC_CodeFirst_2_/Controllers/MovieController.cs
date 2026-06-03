using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CodeFirst_2_.Repository;
using MVC_CodeFirst_2_.Models;

namespace MVC_CodeFirst_2_.Controllers
{
    public class MovieController : Controller
    {

        ConcreteMovieRepo repository = new ConcreteMovieRepo();
        // GET: Movie
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            repository.Insert(movie);
            repository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Movie movie = repository.GetById(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            repository.Update(movie);
            repository.Save();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            repository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult MovieByYear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MovieByYear(int year)
        {
            var movies = repository.GetAll().Where(m => m.DateOfRelease.Year == year).ToList();

            return View("YearResult", movies);
        }

        public ActionResult MoviesByDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoviesByDirector(string directorName)
        {
            var movies = repository.GetAll().Where(m => m.DirectorName == directorName).ToList();

            return View("DirectorResult", movies);
        }

    }
}