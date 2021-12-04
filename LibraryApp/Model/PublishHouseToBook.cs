using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryApp.Model
{
    public partial class PublishHouseToBook
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public int? PublishHouseId { get; set; }

        public virtual Book Book { get; set; }
        public virtual PublishHouse PublishHouse { get; set; }
    }
}
