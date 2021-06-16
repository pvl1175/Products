using Products.DataLayer;
using Products.Domain;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Products.Infrastructure
{
    public static class Resolver
    {
        public static (string, AttributeType) ResolveAndSerialize(AbstractAttribute attribute)
        {
            return attribute.Serialize();

            if (attribute is SimpleAttribute<int> sa)
                return (JsonSerializer.Serialize<SimpleAttribute<int>>(sa), AttributeType.SimpleInt);

            if (attribute is SimpleCurrencyAttribute<decimal> sc)
                return (JsonSerializer.Serialize<SimpleCurrencyAttribute<decimal>>(sc), AttributeType.SimpleCurrencyDecimal);

            if (attribute is SimpleMeasurableAttribute<decimal> sm)
                return (JsonSerializer.Serialize<SimpleMeasurableAttribute<decimal>>(sm), AttributeType.SimpleMeasurableDouble);

            if (attribute is CompoundAttribute ca)
                return (JsonSerializer.Serialize<CompoundAttribute>(ca), AttributeType.Compound);

            throw new ArgumentException(nameof(attribute));
        }
    }
}
