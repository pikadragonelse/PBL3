using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class BookDetail
    {
        public BookDetail ()
        {
            this.Phongs = new HashSet<Phong>();
        }

        [Key]
        [Required]
        [StringLength(10)]
        public string IdBookDetail { get; set; }


        [Required]
        [StringLength(10)]
        public string IdBook { get; set; }
        [ForeignKey("IdBook")]
        public virtual Book Book { get; set; }

        [Required]
        [StringLength(10)]
        public string IdPhong { get; set; }
        [ForeignKey("IdPhong")]
        public virtual ICollection<Phong> Phongs { get; set; }



    }
}
