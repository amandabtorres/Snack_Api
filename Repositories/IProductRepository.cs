using Snack_Api.Entities;

namespace Snack_Api.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);

        Task<IEnumerable<Product>> GetPopularProductsAsync();

        Task<IEnumerable<Product>> GetBestSellerProductsAsync();

        Task<Product> GetProductDetailsAsync(int id);
    }
}
