using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryApp.Model
{
    public partial class BookWithAuthor
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}
