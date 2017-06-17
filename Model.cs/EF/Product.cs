namespace Model.cs.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.RecentlyViews = new HashSet<RecentlyView>();
            this.Reviews = new HashSet<Review>();
            this.Wishlists = new HashSet<Wishlist>();
        }

        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int SupplierID { get; set; }

        public int CategoryID { get; set; }


        public Nullable<int> SubCategoryID { get; set; }

        [StringLength(50)]
        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal? OldPrice { get; set; }

        [StringLength(50)]
        public string UnitWeight { get; set; }

        [StringLength(50)]
        public string Size { get; set; }

        public decimal? Discount { get; set; }

        public int? UnitInStock { get; set; }

        public int? UnitOnOrder { get; set; }

        public bool? ProductAvailable { get; set; }

        [StringLength(500)]
        public string ImageURL { get; set; }

        [StringLength(50)]
        public string AltText { get; set; }

        public bool? AddBadge { get; set; }

        [StringLength(50)]
        public string OfferTitle { get; set; }

        [StringLength(50)]
        public string OfferBadgeClass { get; set; }

        [StringLength(300)]
        public string ShortDescription { get; set; }

        [StringLength(2000)]
        public string LongDescription { get; set; }

        [StringLength(500)]
        public string Picture1 { get; set; }

        [StringLength(500)]
        public string Picture2 { get; set; }

        [StringLength(500)]
        public string Picture3 { get; set; }

        [StringLength(500)]
        public string Picture4 { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<RecentlyView> RecentlyViews { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
