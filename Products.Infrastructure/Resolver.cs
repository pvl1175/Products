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
            if (attribute is SimpleAttribute<int>)
                return (attribute.Serialize(), AttributeType.SimpleInt);

            if (attribute is SimpleCurrencyAttribute<decimal>)
                return (attribute.Serialize(), AttributeType.SimpleCurrencyDecimal);

            if (attribute is SimpleMeasurableAttribute<decimal>)
                return (attribute.Serialize(), AttributeType.SimpleMeasurableDouble);

            if (attribute is CompoundAttribute)
                return (attribute.Serialize(), AttributeType.Compound);

            throw new ArgumentException(nameof(attribute));
        }
    }
}
