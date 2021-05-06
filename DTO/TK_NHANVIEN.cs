using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan3_codefirst1.DTO
{
    public class TK_NHANVIEN
    {
        [Key]
        [ForeignKey("NHAN_VIEN")]
        public string MaNhanVien { get; set; }
        public string Pass { get; set; }
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
