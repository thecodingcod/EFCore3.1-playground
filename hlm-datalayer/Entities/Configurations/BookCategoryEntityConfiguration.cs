using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Entities.Configurations
{
    class BookCategoryEntityConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            // Configuring the Primary Key
            builder.HasKey(bc => new { BookId = bc.BookId, CategoryId = bc.CategoryId });

            // Configuring the Relationships
            builder.HasOne<Book>(bc => bc.Book).WithMany(b => b.Categories).HasForeignKey(bc => bc.BookId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Category>(bc => bc.Category).WithMany(b => b.Books).HasForeignKey(bc => bc.CategoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
