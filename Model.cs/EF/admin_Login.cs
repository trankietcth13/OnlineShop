namespace Model.cs.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admin_Login
    {
        [Key]
        [Column(Order = 0)]
        public int LoginID { get; set; }

        public int EmpID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int? RoleType { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        public virtual Role Role { get; set; }
    }
}
