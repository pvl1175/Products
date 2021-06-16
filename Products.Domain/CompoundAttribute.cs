using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Products.Domain
{
    public class CompoundAttribute : AbstractAttribute
    {
        public List<AbstractAttribute> Attributes { get; } = new List<AbstractAttribute>();

        public override string Serialize()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
