using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }



        public virtual ICollection<BookCategory> Books { get; set; }
    }
}
