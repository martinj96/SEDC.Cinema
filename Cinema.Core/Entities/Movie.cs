using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ImageUrl { get; set; }
        public int TicketPrice { get; set; }
        public virtual ICollection<Hall> Halls { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Genre> Gengres { get; set; }
    }
}
