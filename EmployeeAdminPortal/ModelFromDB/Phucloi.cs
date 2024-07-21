using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("PHUCLOI")]
public partial class Phucloi
{
    [Key]
    [Column("IDPL")]
    public int Idpl { get; set; }

    [Column("LOAIPHUCLOI")]
    [StringLength(50)]
    public string? Loaiphucloi { get; set; }

    [Column("NGAY")]
    public DateOnly? Ngay { get; set; }

    [Column("SOTIEN")]
    public double? Sotien { get; set; }

    [InverseProperty("Idpc1")]
    public virtual ICollection<Luong> Luongs { get; set; } = new List<Luong>();
}
