using eTicketsQ.Data.Base;
using eTicketsQ.Models;

namespace eTicketsQ.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) 
        {
           
        }
    }
}
