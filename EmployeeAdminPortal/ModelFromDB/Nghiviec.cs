using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("NGHIVIEC")]
public partial class Nghiviec
{
    [Key]
    [Column("IDNGHI")]
    public int Idnghi { get; set; }

    [Column("IDLUONG")]
    public int? Idluong { get; set; }

    [Column("COPHEP")]
    public bool? Cophep { get; set; }

    [Column("LYDO")]
    [StringLength(200)]
    public string? Lydo { get; set; }

    [Column("NGAYNGHIBATDAU")]
    public DateOnly? Ngaynghibatdau { get; set; }

    [Column("NGAYNGHIKETTHUC")]
    public DateTimeOffset? Ngaynghiketthuc { get; set; }

    [Column("NGUOIDUYET")]
    [StringLength(50)]
    public string? Nguoiduyet { get; set; }

    [InverseProperty("IdnghiNavigation")]
    public virtual ICollection<Luong> Luongs { get; set; } = new List<Luong>();
}
