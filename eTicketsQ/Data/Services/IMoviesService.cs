using eTicketsQ.Data.Base;
using eTicketsQ.Data.ViewModels;
using eTicketsQ.Models;

namespace eTicketsQ.Data.Services
{
    public interface IMoviesService :IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateNewMovieAsync(NewMovieVM data);
    }
}
