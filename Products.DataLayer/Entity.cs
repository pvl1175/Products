using System;
using System.ComponentModel.DataAnnotations;

namespace Products.DataLayer
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        public DateTime SystemCreated { get; set; }
        public DateTime SystemUpdated { get; set; }
    }
}
