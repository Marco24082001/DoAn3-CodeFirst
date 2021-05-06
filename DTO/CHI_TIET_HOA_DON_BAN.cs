using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace doan3_codefirst1.DTO
{
    public class CHI_TIET_HOA_DON_BAN
    {
        [Key]
        public string ID { get; set; }
        public string MaDonBan { get; set; }
        public string MaSach { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }
        public virtual HOA_DON_BAN HOA_DON_BAN { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
