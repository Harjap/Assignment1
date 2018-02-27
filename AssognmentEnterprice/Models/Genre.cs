namespace AssognmentEnterprice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Genre")]
    public partial class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }
        public int GenreId { get; set; }

        [StringLength(120)]
        [Display(Name="Genre")]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
