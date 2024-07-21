using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("BAOHIEM")]
public partial class Baohiem
{
    [Key]
    [Column("IDBH")]
    public int Idbh { get; set; }

    [Column("IDNV")]
    public int? Idnv { get; set; }

    [Column("SOBH")]
    public int? Sobh { get; set; }

    [Column("NGAYCAP")]
    public DateOnly? Ngaycap { get; set; }

    [Column("NOICAP")]
    [StringLength(200)]
    public string? Noicap { get; set; }

    [Column("THOIHAN")]
    public DateOnly? Thoihan { get; set; }

    [Column("NOIKHAMBENH")]
    [StringLength(200)]
    public string? Noikhambenh { get; set; }

    [ForeignKey("Idnv")]
    [InverseProperty("Baohiems")]
    public virtual Nhanvien? IdnvNavigation { get; set; }
}
