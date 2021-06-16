using Microsoft.EntityFrameworkCore;
using Products.DataLayer;
using Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Products.Infrastructure
{
    public class AttributeRepository : IAttributeRepository
    {
        private ProductContext context;

        public AttributeRepository(ProductContext context)
        {
            this.context = context;
        }

        public async Task AddAttributeAsync<TValue>(Product product, AbstractAttribute attribute)
        {
            if (attribute.Id != 0)
                throw new ArgumentException(nameof(attribute));

            Type t0 = attribute.GetType();
            Type t1 = typeof(SimpleAttribute<int>);

            var b = t0.Equals(t1);

            ProductEntity productEntity = await context.Products.SingleOrDefaultAsync(x => x.Id == product.Id);

            (string json, AttributeType attr) resolveData = Resolver.ResolveAndSerialize(attribute);

            AttributeEntity attributeEntity = new AttributeEntity()
            {
                Data = resolveData.json,
                AttributeType = resolveData.attr,
                Name = attribute.Name, 
                SystemName = attribute.SystemName
            };

            await context.ProductsAttributes.AddAsync(new ProductAttributeEntity()
            {
                ProductEntity = productEntity,
                AttributeEntity = attributeEntity
            });

            await context.SaveChangesAsync();
        }

        public async Task DeleteAttributeAsync(string Name)
        {
            AttributeEntity attributeEntity = await context.Attributes.SingleOrDefaultAsync(x => x.Name == Name);

            if(attributeEntity != null)
            {
                context.Attributes.Remove(attributeEntity);
                await context.SaveChangesAsync();
            }
        }

        public Task EditAttributeAsync(string Name)
        {
            // here
            // 1. entity.Data must be resolved and deserialized (use entity.AttributeType, registered types)
            // 2. update attribute info
            // 3. entity.Data must be resolved and serialized
            // 4. save to db

            throw new NotImplementedException();
        }

        public async Task<AbstractAttribute> FindByAsync(Expression<Func<AttributeEntity, bool>> expression)
        {
            var entity = await context.Attributes.SingleOrDefaultAsync(expression);

            // here
            // 1. entity.Data must be resolved and deserialized (use entity.AttributeType, registered types)

            throw new NotImplementedException();
        }
    }
}
