using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Actor : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
