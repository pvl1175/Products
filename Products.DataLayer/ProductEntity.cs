using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.DataLayer
{
    [Index(nameof(Name), IsUnique = true)]
    public class ProductEntity : Entity
    {
        public string Name { get; set; }
        public List<ProductAttributeEntity> Attributes { get; } = new List<ProductAttributeEntity>();
    }
}
