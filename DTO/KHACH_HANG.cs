using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan3_codefirst1.DTO
{
    public class KHACH_HANG
    {
        [Key]
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public virtual ICollection<HOA_DON_BAN> HOA_DON_BANs { get; set; }
    }
}
