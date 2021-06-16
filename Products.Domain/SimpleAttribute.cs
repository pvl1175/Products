using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Products.Domain
{
    public class SimpleAttribute<TValue> : UserAttribute<TValue>
    {
        public override string Serialize()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
