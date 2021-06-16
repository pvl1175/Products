using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Products.Domain
{
    public abstract class AbstractAttribute
    {
        public int Id { get; set; }
        public string SystemName { get; set; }
        public string Name { get; set; }

        public abstract string Serialize();
    }

    public abstract class UserAttribute<TValue> : AbstractAttribute
    {
        public TValue Value { get; set; }

        public override string Serialize()
        {
            return "";
        }
    }
}
