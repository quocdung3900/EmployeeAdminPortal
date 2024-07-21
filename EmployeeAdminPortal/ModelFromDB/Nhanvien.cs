using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("NHANVIEN")]
public partial class Nhanvien
{
    [Key]
    [Column("IDNV")]
    public int Idnv { get; set; }

    [Column("HOTEN")]
    [StringLength(50)]
    public string? Hoten { get; set; }

    [Column("GIOITINH")]
    public bool? Gioitinh { get; set; }

    [Column("NGAYSINH")]
    public DateOnly? Ngaysinh { get; set; }

    [Column("DIACHI")]
    [StringLength(200)]
    public string? Diachi { get; set; }

    [Column("QUEQUAN")]
    [StringLength(50)]
    public string? Quequan { get; set; }

    [Column("DIENTHOAI")]
    public int? Dienthoai { get; set; }

    [Column("EMAIL")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("CCCD")]
    public int? Cccd { get; set; }

    [Column("QUOCTICH")]
    [StringLength(50)]
    public string? Quoctich { get; set; }

    [Column("TTHONNHAN")]
    public bool? Tthonnhan { get; set; }

    [Column("QTCT")]
    [StringLength(50)]
    public string? Qtct { get; set; }

    [InverseProperty("IdnvNavigation")]
    public virtual ICollection<Baohiem> Baohiems { get; set; } = new List<Baohiem>();

    [InverseProperty("IdnvNavigation")]
    public virtual ICollection<Taisan> Taisans { get; set; } = new List<Taisan>();

    [InverseProperty("IdnvNavigation")]
    public virtual ICollection<Hopdong> Hopdongs { get; set; } = new List<Hopdong>();

    [InverseProperty("IdnvNavigation")]
    public virtual ICollection<Phongban> Phongbans { get; set; } = new List<Phongban>();
}
