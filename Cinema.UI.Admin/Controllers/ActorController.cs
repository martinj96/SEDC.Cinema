using Cinema.AppServices.DTOs;
using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Admin.Controllers
{
    public class ActorController : BaseController
    {
        // GET: Actor
        public ActionResult Index()
        {
            var actors = _actorService.GetAllNotDeleted();
            return View(actors);
        }

        // GET: Actor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actor/Create
        [HttpPost]
        public ActionResult Create(ActorDto actor)
        {
            try
            {
                _actorService.AddActor(actor);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Actor/Delete/5
 
        public RedirectToRouteResult Delete(int id)
        {
            _actorService.DeleteActor(id);

             return RedirectToAction("Index");
        }
    }
}
