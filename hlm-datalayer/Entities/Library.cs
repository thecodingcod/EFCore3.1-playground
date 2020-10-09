using System;
using System.Collections.Generic;

namespace hlm_datalayer.Entities
{
    public class Library
    {
        public int LibraryId { get; set; }
        public string Description { get; set; }
        public string ProfileImgUrl { get; set; }


        // Navigational Property
        public virtual ICollection<Book> Books { get; set; }



    }
}
