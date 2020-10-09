using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Entities
{
    public class Author
    {
        // Id Also represent a userId (1-1) Relationship
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public string ProfileImgUrl { get; set; }


        public virtual ICollection<BookAuthor> Books { get; set; }
    }
}
