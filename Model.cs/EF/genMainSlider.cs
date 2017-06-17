namespace Model.cs.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("genMainSlider")]
    public partial class genMainSlider
    {
        [Key]
        public int MainSliderID { get; set; }

        [StringLength(500)]
        public string ImageURL { get; set; }

        [StringLength(255)]
        public string AltText { get; set; }

        [StringLength(50)]
        public string OfferTag { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(50)]
        public string BtnText { get; set; }

        public bool? isDeleted { get; set; }
    }
}
