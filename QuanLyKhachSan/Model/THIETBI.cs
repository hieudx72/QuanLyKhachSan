namespace QuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THIETBI")]
    public partial class THIETBI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idPhong { get; set; }

        [Required]
        [StringLength(255)]
        public string TenThietBi { get; set; }

        public int SoLuong { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
