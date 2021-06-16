using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Products.DataLayer
{
    public enum AttributeType
    {
        SimpleInt,
        SimpleCurrencyDecimal,
        SimpleMeasurableDouble,
        Compound
    }

    [Index(nameof(SystemName), IsUnique = true)]
    public class AttributeEntity : Entity
    {
        public string SystemName { get; set; }
        public string Name { get; set; }
        public AttributeType AttributeType { get; set; }
        public string Data { get; set; }
        public List<ProductAttributeEntity> Products { get; } = new List<ProductAttributeEntity>();
    }
}
