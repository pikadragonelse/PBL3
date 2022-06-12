using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class TrangThaiVatDung
    {
        public TrangThaiVatDung()
        {
            this.VatDungPhongs = new HashSet<VatDungPhong>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string IdTrangThaiVatDung { get; set; }
        [Required]
        public string MoTa { get; set; }
        public virtual ICollection<VatDungPhong> VatDungPhongs { get; set; }
    }
}
