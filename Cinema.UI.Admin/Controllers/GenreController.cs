using Cinema.AppServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Admin.Controllers
{
    public class GenreController : BaseController
    {
        // GET: Genre
        public ActionResult Index()
        {
            var genres = _genreService.GetAllNotDeleted();
            return View(genres);
        }

        // GET: Genre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genre/Create
        [HttpPost]
        public ActionResult Create(GenreDto genre)
        {
            try
            {
                _genreService.AddGenre(genre);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Genre/Delete/5 
        public RedirectToRouteResult Delete(int id)
        {
            _genreService.DeleteGenre(id);

             return RedirectToAction("Index");
        }
    }
}
