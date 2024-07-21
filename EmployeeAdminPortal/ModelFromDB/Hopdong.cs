using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("HOPDONG")]
public partial class Hopdong
{
    [Key]
    [Column("IDHD")]
    public int Idhd { get; set; }

    [Column("TENHP")]
    [StringLength(50)]
    public string? Tenhp { get; set; }

    [Column("NGAYBATDAU")]
    public DateOnly? Ngaybatdau { get; set; }

    [Column("NGAYKETTHUC")]
    public DateTimeOffset? Ngayketthuc { get; set; }

    [Column("NGAYKY")]
    public DateOnly? Ngayky { get; set; }

    [Column("IDNV")]
    public int? Idnv { get; set; }

    [Column("NGUOILAMHOPDONG")]
    [StringLength(50)]
    public string? Nguoilamhopdong { get; set; }

    [Column("IDLUONG")]
    public int? Idluong { get; set; }

    [Column("HESOLUONG")]
    public double? Hesoluong { get; set; }

    [ForeignKey("Idnv")]
    [InverseProperty("Hopdongs")]
    public virtual Nhanvien? IdnvNavigation { get; set; }

    [InverseProperty("IdhdNavigation")]
    public virtual ICollection<Luong> Luongs { get; set; } = new List<Luong>();
}
