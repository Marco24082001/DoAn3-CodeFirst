using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan3_codefirst1.DTO
{
    public class NHAN_VIEN
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string DanToc { get; set; }
        public bool GioiTinh { get; set; }
        public string CMND { get; set; }
        public string SoDienThoai { get; set; }
        public string QueQuan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TrangThai { get; set; }
        public bool isAdmin { get; set; }
        public virtual ICollection<HOA_DON_BAN> HOA_DON_BANs { get; set; }
        public virtual TK_NHANVIEN TK_NHANVIENs { get; set; }
    }
}
