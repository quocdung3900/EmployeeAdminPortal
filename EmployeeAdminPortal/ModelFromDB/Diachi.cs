using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("DIACHI")]
public partial class Diachi
{
    [Key]
    [Column("IDDIACHI")]
    public int Iddiachi { get; set; }

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

    [Column("IDND")]
    public int Idnv { get; set; }

    [ForeignKey("Idnv")]
    [InverseProperty("Diachis")]
    public virtual Nhanvien? IdnvNavigation { get; set; }
}
