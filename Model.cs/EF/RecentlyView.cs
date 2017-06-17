namespace Model.cs.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RecentlyView
    {
        [Key]
        public int RViewID { get; set; }

        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public System.DateTime ViewDate { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
