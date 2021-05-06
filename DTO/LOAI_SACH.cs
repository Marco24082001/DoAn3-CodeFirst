using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan3_codefirst1.DTO
{
    public class LOAI_SACH
    {
        [Key]
        public string MaLoaiSach { get; set; }
        public string TenLoaiSach { get; set; }
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
