using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Purchase : BaseEntity
    {
        public User User { get; set; }
        public Movie Movie { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public Decimal TotalPrice { get; set; }
    }
}
