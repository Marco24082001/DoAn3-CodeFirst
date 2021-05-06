using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan3_codefirst1.DTO
{
    public class HOA_DON_BAN
    {
        [Key]
        public string MaDonBan { get; set; }
        public string MaKH { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayBan { get; set; }
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
        public virtual KHACH_HANG KHACH_HANG { get; set; }
        public virtual ICollection<CHI_TIET_HOA_DON_BAN> CHI_TIET_HOA_DON_BANs { get; set; }
    }
}
