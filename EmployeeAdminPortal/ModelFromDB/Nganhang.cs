using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("NGANHANG")]
public partial class Nganhang
{
    [Key]
    [Column("IDNH")]
    public int Idnh { get; set; }

    [Column("TENNH")]
    [StringLength(50)]
    public string? Tennh { get; set; }

    [Column("CHINHANH")]
    [StringLength(200)]
    public string? Chinhanh { get; set; }

    [InverseProperty("IdnhNavigation")]
    public virtual ICollection<Luong> Luongs { get; set; } = new List<Luong>();
}
