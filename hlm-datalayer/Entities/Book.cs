using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PagesCount { get; set; }
        public string CoverImgUrl { get; set; }

        /// <summary>
        /// The Date of Creation, Automatically Generated Upon Add
        /// </summary>
        public DateTime? Created { get; set; }

        // Navigational Property
        public int LibraryId { get; set; }
        public virtual Library Library { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
        public virtual ICollection<BookAuthor> Authors { get; set; }
        public virtual ICollection<BookCategory> Categories { get; set; }

    }
}
