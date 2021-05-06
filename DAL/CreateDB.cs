using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan3_codefirst1.DTO;


namespace doan3_codefirst1.DAL
{
    class CreateDB : DropCreateDatabaseIfModelChanges<DBQLB>
    {
        protected override void Seed(DBQLB context)
        {
            context.LOAI_SACHes.AddRange(new LOAI_SACH[]
            {
                new LOAI_SACH {MaLoaiSach = "L001", TenLoaiSach = "Tien Hiep"},
                new LOAI_SACH {MaLoaiSach = "L002", TenLoaiSach = "Day Doi"},
            });
            context.NHA_XUAT_BANs.AddRange(new NHA_XUAT_BAN[]
            {
                new NHA_XUAT_BAN {MaNXB = "NXB1", TenNXB = "Vo Thanh Vi" },
                new NHA_XUAT_BAN {MaNXB = "NXB2", TenNXB = "KO" },
            });
            context.SACHes.AddRange(new SACH[]
            {
                new SACH {MaSach = "001", TenSach = "Dac Nhan Tam", GiaBan = 20000, SoLuong = 10, MaNXB = "NXB1", MaLoaiSach = "L001"},
                new SACH {MaSach = "002", TenSach = "Dac Nhan Tam1", GiaBan = 30000, SoLuong = 20, MaNXB = "NXB2", MaLoaiSach = "L002"},
                new SACH {MaSach = "003", TenSach = "Dac Nhan Tam2", GiaBan = 10000, SoLuong = 40, MaNXB = "NXB2", MaLoaiSach = "L001"},
            });
            context.NHAN_VIENs.AddRange(new NHAN_VIEN[]
            {
                new NHAN_VIEN {MaNhanVien = "NV01", HoTen = "Lieu Minh", DanToc = "Kinh", GioiTinh = true, CMND = "012312312", SoDienThoai = "01225990510", QueQuan = "daNang", NgaySinh = DateTime.Now, isAdmin = false},
                new NHAN_VIEN {MaNhanVien = "NV02", HoTen = "Muc Tran", DanToc = "InDo", GioiTinh = true, CMND = "012312334", SoDienThoai = "07995990510", QueQuan = "Thuong Gioi", NgaySinh = DateTime.Now, isAdmin = true},
            });
            context.KHACH_HANGs.AddRange(new KHACH_HANG[]
            {
                new KHACH_HANG {MaKH = "KH01", HoTen = "Tran Thi Kim Thi", SDT = "012141212"},
                new KHACH_HANG {MaKH = "KH02", HoTen = "Tran Thi Kim Oanh", SDT = "0121124442"},
            });

            context.HOA_DON_NHAPs.AddRange(new HOA_DON_NHAP[]
            {
                new HOA_DON_NHAP {MaDonNhap = "DN01", NgayNhap = DateTime.Now, GhiChu = "Thieu 20k"},
                new HOA_DON_NHAP {MaDonNhap = "DN02", NgayNhap = DateTime.Now, GhiChu = "Thieu 10k"},
            });
            context.CHI_TIET_HOA_DON_NHAPs.AddRange(new CHI_TIET_HOA_DON_NHAP[]
            {
                new CHI_TIET_HOA_DON_NHAP {ID = "CT01", MaDonNhap = "DN01", MaSach = "001", GiaNhap = 15000, SoLuong = 15, ThanhTien = 15000*15},
                new CHI_TIET_HOA_DON_NHAP {ID = "CT02", MaDonNhap = "DN01", MaSach = "002", GiaNhap = 20000, SoLuong = 25, ThanhTien = 20000*25},
                new CHI_TIET_HOA_DON_NHAP {ID = "CT03", MaDonNhap = "DN01", MaSach = "003", GiaNhap = 5000, SoLuong = 40, ThanhTien = 20000*25},
            });
            context.HOA_DON_BANs.AddRange(new HOA_DON_BAN[]
            {
                new HOA_DON_BAN {MaDonBan = "DB01", NgayBan = DateTime.Now, MaKH = "KH01", MaNhanVien = "NV01"}
            });
            context.CHI_TIET_HOA_DON_BANs.AddRange(new CHI_TIET_HOA_DON_BAN[]
            {
                new CHI_TIET_HOA_DON_BAN {ID = "CT01", MaDonBan = "DB01", MaSach = "001", SoLuong = 5, DonGia = 5*20000},
                new CHI_TIET_HOA_DON_BAN {ID = "CT02", MaDonBan = "DB01", MaSach = "002", SoLuong = 5, DonGia = 5*30000},
            });
            context.TK_NHANVIENs.AddRange(new TK_NHANVIEN[]
            {
                new TK_NHANVIEN {MaNhanVien = "NV01", Pass = "24082001"},
                new TK_NHANVIEN {MaNhanVien = "NV02", Pass = "13122001"},
            });
        }
    }
}
