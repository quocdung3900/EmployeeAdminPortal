using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("CHINHANH")]
public partial class Chinhanh
{
    [Key]
    [Column("IDCHINHANH")]
    public int Idchinhanh { get; set; }

    [Column("IDNH")]
    public int? Idnh { get; set; }

    [Column("QUOCGIA")]
    [StringLength(50)]
    public string? Quocgia { get; set; }

    [Column("TINHTHANH")]
    [StringLength(50)]
    public string? Tinhthanh { get; set; }

    [Column("QUAN")]
    [StringLength(50)]
    public string? Quan { get; set; }

    [Column("PHUONG")]
    [StringLength(50)]
    public string? Phuong { get; set; }

    [InverseProperty("IdchinhanhNavigation")]
    public virtual ICollection<Nganhang> Nganhangs { get; set; } = new List<Nganhang>();
}