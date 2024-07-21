using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("OVERTIME")]
public partial class Overtime
{
    [Key]
    [Column("IDOT")]
    public int Idot { get; set; }

    [Column("IDPC")]
    public int? Idpc { get; set; }

    [Column("SOGIO")]
    public int? Sogio { get; set; }

    [Column("HESOLUONG")]
    public double? Hesoluong { get; set; }

    [Column("SOTIEN")]
    public double? Sotien { get; set; }

    [InverseProperty("IdotNavigation")]
    public virtual ICollection<Phucap> Phucaps { get; set; } = new List<Phucap>();
}
