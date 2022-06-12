using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Phong
    {
        public Phong()
        {
            this.VatDungPhongs = new HashSet<VatDungPhong>();
            this.DetailBooks = new HashSet<BookDetail>();
            this.DoThatLacs = new HashSet<DoThatLac>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string IdPhong { get; set; }
        public virtual ICollection<DoThatLac> DoThatLacs { get; set; }
        [StringLength(10)]
        [Required]

        public string IdLoaiPhong { get; set; }
        [ForeignKey("IdLoaiPhong")]
        public virtual LoaiPhong LoaiPhong { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        public string Name { get; set; }
        public virtual ICollection<VatDungPhong> VatDungPhongs { get; set; }
        public virtual ICollection<BookDetail> DetailBooks { get; set; }

    }
}
