using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Products.Domain
{
    public enum Currency
    {
        USD
    }

    public class SimpleCurrencyAttribute<TValue> : UserAttribute<TValue>
    {
        public Currency Currency { get; set; }

        public override string Serialize()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
