using eTicketsQ.Data.Base;
using eTicketsQ.Models;

namespace eTicketsQ.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context): base(context) 
        {
                
        }
    }
}
