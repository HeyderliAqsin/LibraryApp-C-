using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryApp.Model
{
    public partial class PublishHouse
    {
        public PublishHouse()
        {
            PublishHouseToBooks = new HashSet<PublishHouseToBook>();
        }

        public int PublishHouseId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PublishHouseToBook> PublishHouseToBooks { get; set; }
    }
}
