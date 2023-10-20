namespace WindowsFormsApp.ADO.NET_.NET_Framework_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [Key]
        public int BookCode { get; set; }

        [Required]
        [StringLength(200)]
        public string BookName { get; set; }

        public int? GenreCode { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
