using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; private set; }
        public virtual bool IsDeleted { get; set; }
        public BaseEntity()
        {
            DateCreated = DateTime.Now;
        }
    }
}
