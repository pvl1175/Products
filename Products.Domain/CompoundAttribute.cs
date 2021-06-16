using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Domain
{
    public class CompoundAttribute : AbstractAttribute
    {
        public List<AbstractAttribute> Attributes { get; } = new List<AbstractAttribute>();
    }
}
