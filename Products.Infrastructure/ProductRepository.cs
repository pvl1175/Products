using Microsoft.EntityFrameworkCore;
using Products.DataLayer;
using Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext context;

        public ProductRepository(ProductContext context)
        {
            this.context = context;
        }

        public async Task AddProductAsync(Product product)
        {
            ProductEntity productEntity = new ProductEntity()
            {
                Name = product.Name
            };

            context.Products.Add(productEntity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Product product)
        {
            ProductEntity productEntity = await context.Products.SingleOrDefaultAsync(x => x.Name == product.Name);
            if (productEntity != null)
            {
                context.Products.Remove(productEntity);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditProductAsync(Product product)
        {
            ProductEntity productEntity = await context.Products.SingleOrDefaultAsync(x => x.Name == product.Name);
            if (productEntity != null)
            {
                productEntity.Name = product.Name;
                await context.SaveChangesAsync();
            }
        }

        public async Task<Product> FindByAsync(Expression<Func<ProductEntity, bool>> expression)
        {
            var productEntity = await context.Products.SingleOrDefaultAsync(expression);
            if(productEntity != null)
            {
                return new Product() { Name = productEntity.Name };
            }

            return null;
        }
    }
}
