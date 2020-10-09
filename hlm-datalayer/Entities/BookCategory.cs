using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Entities
{
    public class BookCategory
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }


        // Nav Properties
        public virtual Book Book { get; set; }
        public virtual Category Category { get; set; }
    }
}
