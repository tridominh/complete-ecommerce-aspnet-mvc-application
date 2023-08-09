using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ProducerService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducerService(AppDbContext context) : base(context) { }
        
    }
}