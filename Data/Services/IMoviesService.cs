using commerceApplication.Models;
using static commerceApplication.Data.Base.IEntityBaseRepository;

namespace commerceApplication.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
