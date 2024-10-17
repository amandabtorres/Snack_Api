using Snack_Api.Entities;

namespace Snack_Api.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
