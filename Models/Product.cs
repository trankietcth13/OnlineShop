//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Wishlists = new HashSet<Wishlist>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public int SubcategoryID { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> OldPrice { get; set; }
        public string UnitWeight { get; set; }
        public string Size { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<int> UnitInStock { get; set; }
        public string ImageURL { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
        public DateTime CreatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wishlist> Wishlists { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Category Category { get; set; }
    }
}