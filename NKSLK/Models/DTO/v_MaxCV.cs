namespace NKSLK.Models.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_MaxCV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCV { get; set; }

        [StringLength(100)]
        public string TenCV { get; set; }

        public decimal? DinhMucKhoan { get; set; }

        [StringLength(50)]
        public string DonViKhoan { get; set; }

        public int? HeSoKhoan { get; set; }

        public decimal? DinhMucLD { get; set; }

        public int? SoLuong { get; set; }
    }
}
