using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class DoThatLac
    {
        [Key][Required][StringLength(50)]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(10)]
        [Required]
        public string IdPhong { get; set; }
        [ForeignKey("IdPhong")]
        public virtual Phong Phong { get; set; }
        [Required]
        public string TinhTrang { get; set; }
        
    }
}
