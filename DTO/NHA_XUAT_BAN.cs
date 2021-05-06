using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan3_codefirst1.DTO
{
    public class NHA_XUAT_BAN
    {
        [Key]
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
