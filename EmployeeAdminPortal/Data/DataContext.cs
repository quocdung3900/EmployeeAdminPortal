using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Baohiem> Baohiems { get; set; }

    public virtual DbSet<Chinhanh> Chinhanhs { get; set; }

    public virtual DbSet<Chucdanh> Chucdanhs { get; set; }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Diachi> Diachis { get; set; }

    public virtual DbSet<Taisan> Taisans { get; set; }

    public virtual DbSet<Hopdong> Hopdongs { get; set; }

    public virtual DbSet<KhenthuongKyluat> KhenthuongKyluats { get; set; }

    public virtual DbSet<Luong> Luongs { get; set; }

    public virtual DbSet<Nganhang> Nganhangs { get; set; }

    public virtual DbSet<Nghiviec> Nghiviecs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Overtime> Overtimes { get; set; }

    public virtual DbSet<Phongban> Phongbans { get; set; }

    public virtual DbSet<Phucap> Phucaps { get; set; }

    public virtual DbSet<Phucloi> Phuclois { get; set; }
 
}
