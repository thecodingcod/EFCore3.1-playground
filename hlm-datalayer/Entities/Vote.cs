using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Entities
{
    public class Vote
    {

        public int VoteId { get; set; }
        public int Stars { get; set; }
        public string Comment { get; set; }



        // Navigational Property
        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        // TODO: Add navigation properties for Users
    }
}
