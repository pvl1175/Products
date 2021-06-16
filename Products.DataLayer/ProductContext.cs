using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.DataLayer
{
    public class ProductContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<AttributeEntity> Attributes { get; set; }
        public DbSet<ProductAttributeEntity> ProductsAttributes { get; set; }

        public ProductContext()
        {
            ChangeTracker.StateChanged += ChangeTracker_StateChanged;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server=.\\;database=products;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        private static bool IsEntityUpdated(EntityState entityState)
        {
            return entityState == EntityState.Modified || entityState == EntityState.Added;
        }

        private void ChangeTracker_StateChanged(object sender, Microsoft.EntityFrameworkCore.ChangeTracking.EntityStateChangedEventArgs e)
        {
            if (!IsEntityUpdated(e.Entry.State))
                return;

            switch (e.Entry.Entity)
            {
                default:
                    break;
            }
        }
    }
}
