namespace AssognmentEnterprice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Author")]
    public partial class Author
    {
        public Author() { }
        public int AuthorId { get; set; }

        [StringLength(120)]
        [Display(Name="Author Name")]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
