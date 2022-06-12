using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class HoaDon
    {
        public HoaDon()
        {
            this.Books = new HashSet<Book>();
            this.LoaiDichVus = new HashSet<LoaiDichVu>();
        }
        [Key][StringLength(10)][Required]
        public string IdHoaDon { get; set; }
        [Required]
        public DateTime NgayThanhToan { get; set; }
        [Required]
        public string TienPhong { get; set; }
        [Required]
        public string TienDichVu { get; set; }
        [Required]
        public string TienVatTu { get; set; }
        [Required]
        public string TongTien { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<LoaiDichVu> LoaiDichVus { get; set; }
    }
}
