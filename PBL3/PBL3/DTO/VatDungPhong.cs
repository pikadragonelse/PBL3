using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class VatDungPhong
    {
        [Key]
        [StringLength(10)]
        [Required]
        public string IdVatDung { get; set; }
        [StringLength(10)]
        [Required]
        public string IdLoaiVatDung { get; set; }
        [ForeignKey("IdLoaiVatDung")]
        public virtual LoaiVatDung LoaiVatDung { get; set; }
        [StringLength(10)]
        [Required]
        public string IdPhong { get; set; }
        [ForeignKey("IdPhong")]
        public virtual Phong Phong { get; set; }
        [Required]
        public int SoLuongBanDau { get; set; }
        [Required]
        public int SoLuongHienTai { get; set; }
        [StringLength(10)]
        [Required]
        public string IdTrangThaiVatDung { get; set; }
        [ForeignKey("IdTrangThaiVatDung")]
        public virtual TrangThaiVatDung TrangThaiVatDung { get; set; }
    }
}
