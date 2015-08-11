using Cinema.AppServices;
using Cinema.Infrastructure.Data;
using Cinema.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected ActorService _actorService;
        protected GenreService _genreService;
        protected HallService _hallService;
        protected MovieService _movieService;
        public BaseController()
        {
            string cnnString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            var dbContext = new CinemaDbContext(cnnString);
            var actorsRepo = new ActorRepository(dbContext);
            _actorService = new ActorService(actorsRepo);
            var genreRepo = new GenreRepository(dbContext);
            _genreService = new GenreService(genreRepo);
            var hallRepo = new HallRepository(dbContext);
            _hallService = new HallService(hallRepo);
            var movieRepo = new MovieRepository(dbContext);
            _movieService = new MovieService(movieRepo, actorsRepo);
        }
    }
}