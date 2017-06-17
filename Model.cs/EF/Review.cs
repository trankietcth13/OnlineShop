namespace Model.cs.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Review")]
    public partial class Review
    {
        public int ReviewID { get; set; }

        public Nullable<int> CustomerID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column("Review")]
        [StringLength(500)]
        public string Review1 { get; set; }

        public Nullable<int> Rate { get; set; }

        public Nullable<System.DateTime> DateTime { get; set; }

        public Nullable<bool> isDelete { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
