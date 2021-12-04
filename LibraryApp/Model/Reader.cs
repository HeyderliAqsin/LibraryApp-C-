using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryApp.Model
{
    public partial class Reader
    {
        public Reader()
        {
            ReaderToBooks = new HashSet<ReaderToBook>();
        }

        public int ReaderId { get; set; }
        public string Fullname { get; set; }

        public virtual ICollection<ReaderToBook> ReaderToBooks { get; set; }
    }
}
