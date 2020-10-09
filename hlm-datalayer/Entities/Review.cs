using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }


        // Navigational Property
        public int BookId { get; set; }
        public virtual Book Book { get; set; }


        // TODO: Add navigation properties for Users

    }
}
