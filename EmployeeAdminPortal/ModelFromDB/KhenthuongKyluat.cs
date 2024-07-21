using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("KHENTHUONG_KYLUAT")]
public partial class KhenthuongKyluat
{
    [Key]
    [Column("IDKTKL")]
    public int Idktkl { get; set; }

    [Column("LOAI")]
    public bool? Loai { get; set; }

    [Column("NOIDUNG")]
    [StringLength(200)]
    public string? Noidung { get; set; }

    [Column("NGAY")]
    public DateOnly? Ngay { get; set; }

    [InverseProperty("IdktklNavigation")]
    public virtual ICollection<Luong> Luongs { get; set; } = new List<Luong>();
}
