using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan3_codefirst1.DTO
{
    public class HOA_DON_NHAP
    {
        [Key]
        public string MaDonNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<CHI_TIET_HOA_DON_NHAP> CHI_TIET_HOA_DON_NHAPs { get; set; }
    }
}
