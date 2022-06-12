using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class DangNhap
    {
        public DangNhap()
        {
            this.NhanViens = new HashSet<NhanVien>();
        }

        [Key][StringLength(10)][Required]

        public string Username { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
        [Required]
        public string MatKhau { get; set; }
        [Required]
        public string IdChucVu { get; set; }

        public bool TrangThai { get; set; }


    }
}
