using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Entities
{
    public class BookAuthor
    {
        // Composite PK
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public int Order { get; set; }


        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }



    }
}
