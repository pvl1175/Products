using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Domain
{
    public enum Currency
    {
        USD
    }

    public class SimpleCurrencyAttribute<TValue> : UserAttribute<TValue>
    {
        public Currency Currency { get; set; }
    }
}
