using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryApp.Model
{
    public partial class Book
    {
        public Book()
        {
            PublishHouseToBooks = new HashSet<PublishHouseToBook>();
            ReaderToBooks = new HashSet<ReaderToBook>();
        }

        public int BookId { get; set; }
        public string Name { get; set; }
        public DateTime? PublishDate { get; set; }
        public int? AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual ICollection<PublishHouseToBook> PublishHouseToBooks { get; set; }
        public virtual ICollection<ReaderToBook> ReaderToBooks { get; set; }
    }
}
