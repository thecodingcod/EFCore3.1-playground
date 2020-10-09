using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Entities.Configurations
{
    class BookAuthorEntityConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {

            // Configuring Primray Key
            builder.HasKey(ba => new { AuthorId = ba.AuthorId, BookId = ba.BookId });

            // Configure Many-To-Many Relationship for BookAuthor Linker Entity
            builder.HasOne<Book>(b => b.Book).WithMany(ba => ba.Authors).HasForeignKey(ba => ba.BookId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Author>(b => b.Author).WithMany(ba => ba.Books).HasForeignKey(ba => ba.AuthorId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
