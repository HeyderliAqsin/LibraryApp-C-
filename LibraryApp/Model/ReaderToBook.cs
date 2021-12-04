using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryApp.Model
{
    public partial class ReaderToBook
    {
        public int ReaderToBookId { get; set; }
        public int? ReaderId { get; set; }
        public int? BookId { get; set; }
        public DateTime GetBookDate { get; set; }
        public DateTime ReturnBookDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Reader Reader { get; set; }
    }
}
