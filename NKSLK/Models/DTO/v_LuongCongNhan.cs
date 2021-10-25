namespace NKSLK.Models.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_LuongCongNhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCN { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [Column("Luong cong nhan")]
        public double? Luong_cong_nhan { get; set; }
    }
}
