namespace DBControl_.NET_Framework_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductCode { get; set; }

        [StringLength(200)]
        public string ProductName { get; set; }

        public int? ProductPrice { get; set; }
    }
}
