﻿using Snack_Api.Context;
using Snack_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Snack_Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Product>> GetBestSellerProductsAsync()
        {
            return await _appDbContext.Products.AsNoTracking().Where(p => p.BestSeller).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetPopularProductsAsync()
        {
            return await _appDbContext.Products.AsNoTracking().Where(p => p.Popular).ToListAsync();
        }

        public async Task<Product> GetProductDetailsAsync(int id)
        {
            var productDetail = await _appDbContext.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

            //if (productDetail is null) throw new InvalidOperationException("O produto procurado não existe");

            return productDetail!;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _appDbContext.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }
    }
}
