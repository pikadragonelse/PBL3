using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class Book
    {
        public Book()
        {
            this.BookDetails = new HashSet<BookDetail>();

        }

        [Key][Required][StringLength(10)]
        public string IdBook { get; set; }
        [Required][StringLength(10)]
        public string IdHoaDon { get; set; }
        [ForeignKey("IdHoaDon")]
        public virtual HoaDon HoaDon { get; set; }
        [Required][StringLength(10)]
        public string IdKhachHang { get; set; }
        [Required][StringLength(10)]
        public string IdNhanVien { get; set; }
        public string  NgayDat { get; set; }
        public string NgayCheckIn { get; set; }
        public string NgayCheckOut { get; set; }
        [Required]
        public DateTime NgayCheckInThucTe { get; set; }
        [Required]
        public DateTime NgayCheckOutThucTe { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<BookDetail> BookDetails { get; set; }

    }
}
