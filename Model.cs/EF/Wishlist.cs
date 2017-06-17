namespace Model.cs.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wishlist")]
    public partial class Wishlist
    {
        public int WishlistID { get; set; }

        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public bool? isActive { get; set; }

        public virtual Product Product { get; set; }
    }
}
