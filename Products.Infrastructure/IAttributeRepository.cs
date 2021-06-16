using Products.DataLayer;
using Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure
{
    public interface IAttributeRepository
    {
        Task AddAttributeAsync<TValue>(Product product, AbstractAttribute attribute);
        Task EditAttributeAsync(string Name);
        Task DeleteAttributeAsync(string Name);
        Task<AbstractAttribute> FindByAsync(Expression<Func<AttributeEntity, bool>> expression);
    }
}
