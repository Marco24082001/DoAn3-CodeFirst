using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan3_codefirst1.DTO
{
    public class CHI_TIET_HOA_DON_NHAP
    {
        [Key]
        public string ID { get; set; }
        public string MaDonNhap { get; set; }
        public string MaSach { get; set; }
        public double GiaNhap { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }
        public virtual HOA_DON_NHAP HOA_DON_NHAP { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
