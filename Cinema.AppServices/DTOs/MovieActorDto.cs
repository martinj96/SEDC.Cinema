using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Cinema.AppServices.DTOs
{
    public class MovieActorDto
    {
        public int movieId { get; set; }
        public IEnumerable<ActorDto> IncludedActors { get; set; }
        public List<SelectListItem> ExcludedActors { get; set; }
    }
}
