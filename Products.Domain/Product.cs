using System;
using System.Collections.Generic;

namespace Products.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AbstractAttribute> Attributes { get; } = new List<AbstractAttribute>();
    }
}
