using hlm_datalayer.Entities;
using hlm_datalayer.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Context
{
    class AppContext : DbContext

    // Instantiate this class to connect, save data to db and many more options that DbConext Provides !
    {
        public AppContext(DbContextOptions options):base(options)
        {
        }

        // Here is where we use the Fluent API & Model-level Queries
        protected override void OnModelCreating(ModelBuilder model)
        {
            // BookAuthor (Linking Table)
            model.ApplyConfiguration(new BookAuthorEntityConfiguration());

            // BookCategory (Linking Table)
            model.ApplyConfiguration(new BookCategoryEntityConfiguration());

            // Book (Entity)
            model.ApplyConfiguration(new BookEntityConfiguration());
        }


        // Allows us to select and configure the data source to be used with a context using DbContextOptionsBuilder argument (optionBuilder).



        // List of Entities DbSet<T>
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Vote> Votes { get; set; }


    }
}
