using System;
using System.Data.Entity;
using System.Linq;
using doan3_codefirst1.DTO;

namespace doan3_codefirst1.DAL
{
    public class DBQLB : DbContext
    {
        // Your context has been configured to use a 'DBQLB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'doan3_codefirst1.DTO.DBQLB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBQLB' 
        // connection string in the application configuration file.
        public DBQLB()
            : base("name=DBQLB")
        {
            Database.SetInitializer<DBQLB>(new CreateDB());
        }

        public virtual DbSet<LOAI_SACH> LOAI_SACHes { get; set; }
        public virtual DbSet<NHA_XUAT_BAN> NHA_XUAT_BANs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<TK_NHANVIEN> TK_NHANVIENs { get; set; }
        public virtual DbSet<HOA_DON_NHAP> HOA_DON_NHAPs { get; set; }
        public virtual DbSet<HOA_DON_BAN> HOA_DON_BANs { get; set; }
        public virtual DbSet<CHI_TIET_HOA_DON_BAN> CHI_TIET_HOA_DON_BANs { get; set; }
        public virtual DbSet<CHI_TIET_HOA_DON_NHAP> CHI_TIET_HOA_DON_NHAPs { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANGs { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIENs { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}