using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("PHUCAP")]
public partial class Phucap
{
    [Key]
    [Column("IDPC")]
    public int Idpc { get; set; }

    [Column("LOAIPHUCAP")]
    [StringLength(50)]
    public string? Loaiphucap { get; set; }

    [Column("IDOT")]
    public int? Idot { get; set; }

    [Column("NGAY")]
    public DateOnly? Ngay { get; set; }

    [Column("SOTIEN")]
    public double? Sotien { get; set; }

    [ForeignKey("Idot")]
    [InverseProperty("Phucaps")]
    public virtual Overtime? IdotNavigation { get; set; }

    [InverseProperty("IdpcNavigation")]
    public virtual ICollection<Luong> Luongs { get; set; } = new List<Luong>();
}
