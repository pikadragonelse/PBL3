using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class LichSuDangNhap
    {
        [Key][StringLength(10)][Required]
        public string idLichSuDangNhap { get; set; }
        [StringLength(10)][Required]
        public string idNhanVien { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        [Required]
        public DateTime ThoiGian { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
