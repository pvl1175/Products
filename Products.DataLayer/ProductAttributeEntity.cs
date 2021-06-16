using System;
using System.Collections.Generic;
using System.Text;

namespace Products.DataLayer
{
    public class ProductAttributeEntity : Entity
    {
        public int ProductEntityId { get; set; }
        public ProductEntity ProductEntity { get; set; }
        public int AttributeEntityId { get; set; }
        public AttributeEntity AttributeEntity { get; set; }
    }
}
