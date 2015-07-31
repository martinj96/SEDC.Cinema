using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
