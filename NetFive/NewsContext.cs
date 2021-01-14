using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFive
{
   //public class NewsContext:DbContext
   // {
   //     public DbSet<News> News { get; set; }
   //     public DbSet<Tag>  Tags { get; set; }

   //     public DbSet<Parent>  Parents { get; set; }

   //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   //     {
   //         optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=News;Integrated Security=true");
   //     }

   // }

     public class PropertyBag:DbContext
    {
        public DbSet<Dictionary<string, object>> Products => Set<Dictionary<string, object>>("Product");
        public DbSet<Dictionary<string, object>> Categories => Set<Dictionary<string, object>>("Category");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Property;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("Category", b =>
            {
                b.IndexerProperty<string>("Name").IsRequired();

                b.IndexerProperty<string>("Description");

                b.IndexerProperty<int>("Id");
            });
            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("Product", b =>
            {
                b.IndexerProperty<string>("Name").IsRequired();

                b.IndexerProperty<string>("Description");

                b.IndexerProperty<int>("Id");
                b.IndexerProperty<decimal>("Price");

                b.IndexerProperty<int?>("CategoryId");

                b.HasOne("Category", null).WithMany();

            });
        }
    }
}
