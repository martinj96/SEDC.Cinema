using Cinema.Core.Entities;
using Cinema.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Data.Repository
{
    public class PurchaseRepository : BaseRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(CinemaDbContext context)
            : base(context)
        {

        }
    }
}
