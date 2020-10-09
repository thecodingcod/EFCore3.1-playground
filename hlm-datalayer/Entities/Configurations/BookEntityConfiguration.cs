using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Entities.Configurations
{
    class BookEntityConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            // Generated Values
            builder.Property(b => b.Created).ValueGeneratedOnAdd();

        }
    }
}
