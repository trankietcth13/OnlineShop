namespace Model.cs.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        public int? CustomerID { get; set; }

        public int? PaymentID { get; set; }

        public int? ShippingID { get; set; }

        public int? Discount { get; set; }

        public int? Taxes { get; set; }

        public int? TotalAmount { get; set; }

        public bool? isCompleted { get; set; }

        public DateTime? OrderDate { get; set; }

        public bool? DIspatched { get; set; }

        public DateTime? DispatchedDate { get; set; }

        public bool? Shipped { get; set; }

        public DateTime? ShippingDate { get; set; }

        public bool? Deliver { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public bool? CancelOrder { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Payment Payment { get; set; }

        public virtual ShippingDetail ShippingDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
