using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan3_codefirst1.DTO
{
    public class SACH
    {
        [Key]
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string MaNXB { get; set; }
        public string MaLoaiSach { get; set; }
        public virtual NHA_XUAT_BAN NHA_XUAT_BAN { get; set; }
        public virtual LOAI_SACH Loai_Sach { get; set; }
        public virtual ICollection<CHI_TIET_HOA_DON_NHAP> CHI_TIET_HOA_DON_NHAPs { get; set; }
        public virtual ICollection<CHI_TIET_HOA_DON_BAN> CHI_TIET_HOA_DON_BANs { get; set; }
    }
}
