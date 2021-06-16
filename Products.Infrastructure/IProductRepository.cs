using Products.DataLayer;
using Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure
{
    public interface IProductRepository
    {
        Task AddProductAsync(Product product);
        Task EditProductAsync(Product product);
        Task DeleteProductAsync(Product product);
        Task<Product> FindByAsync(Expression<Func<ProductEntity, bool>> expression);
    }
}
