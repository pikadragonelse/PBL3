using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class NhanVien
    {
        public NhanVien()
        {
            this.Books = new HashSet<Book>();
            this.LichSuDangNhaps = new HashSet<LichSuDangNhap>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string IdNhanVien { get; set; }
        [StringLength(10)]
        [Required]
        public string Username { get; set; }
        [ForeignKey("Username")]
        public virtual DangNhap DangNhap { get; set; }
        public string IdChucVu { get; set; }
        [Required]
        public string Ten { get; set; }
      
        public bool GioiTinh { get; set; }
    
        public DateTime NgaySinh { get; set; }
        
        public string CMND { get; set; }
       
        public string SDT { get; set; }
       
        public string DiaChi { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public virtual ChucVu ChucVu { get; set; }

        public virtual ICollection<LichSuDangNhap> LichSuDangNhaps { get; set; }
    }
}
