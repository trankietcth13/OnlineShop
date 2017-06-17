namespace Model.cs.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("genPromoRight")]
    public partial class genPromoRight
    {
        [Key]
        public int PromoRightID { get; set; }

        public int CategoryID { get; set; }

        [StringLength(500)]
        public string ImageURL { get; set; }

        [StringLength(500)]
        public string AltText { get; set; }

        [StringLength(50)]
        public string OfferTag { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public bool? isDeleted { get; set; }
    }
}
