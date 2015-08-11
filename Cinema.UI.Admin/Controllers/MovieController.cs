using Cinema.AppServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Admin.Controllers
{
    public class MovieController : BaseController
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = _movieService.GetAllNotDeleted();
            return View(movies);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(MovieDto movie)
        {
            try
            {
                _movieService.AddMovie(movie);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public RedirectToRouteResult Delete(int id)
        {
            _movieService.DeleteMovie(id);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Actors(int id)
        {
            var model = new MovieActorDto();
            model.movieId = id;
            var allActors = _actorService.GetAllNotDeleted();
            model.IncludedActors = _movieService.GetActors(id);
            foreach (var actor in model.IncludedActors)
            {
                allActors.RemoveAll(x => x.Id == actor.Id);
            }
            model.ExcludedActors = allActors.Select(x => new SelectListItem()
            {
                Text = x.ToString(),
                Value = x.Id.ToString()
            }).ToList();
            return View(model);
        }

        [HttpPost, ActionName("Actors")]
        public ActionResult AddActor(int id, int movieId)
        {
            var actor = _actorService.GetActorById(id);
            var movie = _movieService.GetMovieById(movieId);
            _movieService.AddActor(movie, actor);
            return RedirectToAction("Actors", new { id = movieId });
        }
        public RedirectResult Remove(int id, int movieId)
        {
            var actor = _actorService.GetActorById(id);
            var movie = _movieService.GetMovieById(movieId);
            _movieService.RemoveActor(movie, actor);
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}
