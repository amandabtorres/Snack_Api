using Snack_Api.Context;
using Snack_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Snack_Api.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _dbContext;

        public CategoryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _dbContext.Categories.ToListAsync();
        }
    }
}
